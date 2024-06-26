import React, { useEffect } from "react";
import { ResultsTable } from "../ResultsTable/ResultsTable";
import { InputPanel } from "../InputPanel/InputPanel";
import { QueryError } from "./QueryError/QueryError";
import { useState } from "react";
import { MLinkJsonParser, jsonObject } from "../../helpers/MLinkJsonParser";
import BaseApiService from "../../services/BaseAPIService";
import { MLinkConfig } from "../../config";
import { contentStyle } from "./ActionPanel.style";
import { CONN_STATUS } from "../InputPanel/ConnectionPanel/ConnectionPanel";
import { DisplayOption } from "../InputPanel/DisplayPanel/DisplayPanel";
import { msgTypeObject } from "../../types";
import { isPresent } from "../../utils/ActionPanelValidator";
import { QueryPanel } from "../InputPanel/QueryPanel/QueryPanel";

export const ActionPanel: React.FC = () => {
  const [errorVisibility, setErrorMessageVisbility] = useState<boolean>(false);
  const [errorMessage, setErrorMessage] = useState<string | null>(null);
  const [msgData, setMsgData] = useState<jsonObject[]>([]);
  const [msgSchema, setMsgSchema] = useState<string[]>([]);
  const [loading, setLoading] = useState<boolean>(false);
  const [viewFilter, setViewFilter] = useState<string>("");
  const [showInitialContent, setShowInitialContent] = useState<boolean>(true);
  const [msgTypes, setMsgTypes] = useState<msgTypeObject>({});
  const [msgTokens, setMsgTokens] = useState<string[]>([]);
  //Connection Panel
  const [urlValue, setUrlValue] = useState<string>("");
  const [keyValue, setKeyValue] = useState<string>("");
  const [connectStatus, setConnectStatus] = useState<string>(
    CONN_STATUS.DISCONNECTED
  );
  const [config, setConfig] = useState<MLinkConfig>();
  //Display Panel
  const [limitResults, setLimitResults] = useState<number>(500);
  const [displayResults, setDisplayResults] = useState<string>(
    DisplayOption.TABLE
  );
  const [rawData, setRawData] = useState<string>("");
  //Query Panel
  const [queryUrl, setQueryUrl] = useState<string>("");
  const [queryElapsed, setQueryElapsed] = useState<number>(0);

  useEffect(() => {
    if (!config || config.MLINK_ENDPOINT === "" || config.API_KEY === "") {
      setConnectStatus(CONN_STATUS.DISCONNECTED);
      return;
    }
    const baseAPIService = new BaseApiService(config);
    baseAPIService
      .getMsgTypes()
      .then((json) => {
        let msgTypeArray: { [key: string]: string[] } = {};
        let msgTokenArray: string[] = [];
        // eslint-disable-next-line
        for (const [_key, value] of Object.entries(json)) {
          let msgType: string = value["message"]["name"];
          let msgToken: string = value["message"]["mToken"];

          if (isPresent(msgType) && isPresent(msgToken)) {
            if (msgToken in msgTypeArray) {
              msgTypeArray[msgToken].push(msgType);
            } else {
              msgTypeArray[msgToken] = [msgType];
              msgTokenArray.push(msgToken);
            }
          }
        }
        setConnectStatus(CONN_STATUS.CONNECTED);
        setMsgTypes(msgTypeArray);
        setMsgTokens(msgTokenArray.sort());
      })
      .catch((error) => {
        setConnectStatus(CONN_STATUS.DISCONNECTED);
        console.error(error);
      });
  }, [config]);

  useEffect(() => {
    setConnectStatus(CONN_STATUS.CONNECTING);
    const config: MLinkConfig = {
      MLINK_ENDPOINT: urlValue,
      API_KEY: keyValue,
    };
    setConfig(config);
  }, [urlValue, keyValue]);

  const isValidLimit = () => {
    return (
      limitResults !== undefined && limitResults > 0 && limitResults < 10001
    );
  };

  const getQueryElapse = (obj: jsonObject) => {
    let time = obj["queryelapsed"];
    if (time) {
      return time;
    }
    return 0;
  };

  const handleClickRequest = async (
    msgType: string,
    whereFilter: string | undefined
  ) => {
    try {
      if (!config || connectStatus === CONN_STATUS.DISCONNECTED) {
        throw new Error("Invalid connection");
      }
      if (!isValidLimit()) {
        throw new Error("Invalid Limit");
      }
      setShowInitialContent(false);
      setLoading(true);
      const baseAPIService = new BaseApiService(config);
      setQueryUrl(
        baseAPIService.getMessagesURL(
          msgType,
          whereFilter,
          viewFilter,
          limitResults
        )
      );
      baseAPIService
        .getMessages(msgType, whereFilter, viewFilter, limitResults)
        .then((json) => {
          const mlinkResponse =
            MLinkJsonParser.parseMLinkDataToFlattenedArray(json);
          // This block below checks to see if the response
          // from MLink is actually an error message and will display the error if so
          if (
            mlinkResponse.length === 1 &&
            mlinkResponse[0]["result"] === "Error"
          ) {
            setErrorMessageVisbility(true);
            setErrorMessage(mlinkResponse[0]["detail"]);
            setLoading(false);
          } else {
            const time = getQueryElapse(
              mlinkResponse[mlinkResponse.length - 1]
            );
            setQueryElapsed(time);
            setRawData(JSON.stringify(json, null, 2));
            setMsgData(mlinkResponse);
            const schemaArray = MLinkJsonParser.parseMLinkResponseToSchemaArray(
              json,
              viewFilter
            );
            setMsgSchema(schemaArray);
            setLoading(false);
          }
        })
        .catch((error) => {
          setErrorMessageVisbility(true);
          setErrorMessage(error + "");
          setLoading(false);
        });
    } catch (error) {
      setErrorMessageVisbility(true);
      setErrorMessage(error + "");
      setLoading(false);
    }
  };

  const initialContent = () => {
    return (
      <section style={contentStyle}>
        Getting started content goes here...
      </section>
    );
  };

  return (
    <div>
      <InputPanel
        handleClickRequest={handleClickRequest}
        setErrorMessageVisbility={setErrorMessageVisbility}
        setErrorMessage={setErrorMessage}
        setViewFilter={setViewFilter}
        msgTypes={msgTypes}
        msgTokens={msgTokens}
        urlValue={urlValue}
        setUrlValue={setUrlValue}
        keyValue={keyValue}
        setKeyValue={setKeyValue}
        connectStatus={connectStatus}
        limitResults={limitResults}
        setLimitResults={setLimitResults}
        displayResults={displayResults}
        setDisplayResults={setDisplayResults}
      />
      <QueryPanel query={queryUrl} queryElapsed={queryElapsed} />

      <QueryError visible={errorVisibility} message={errorMessage} />

      {showInitialContent && initialContent()}

      {!!!showInitialContent && loading && (
        <div className="loading">Fetching results...</div>
      )}

      {!!!showInitialContent &&
        !!!loading &&
        displayResults === DisplayOption.TABLE && (
          <ResultsTable msgData={msgData} msgSchema={msgSchema} />
        )}

      {!!!showInitialContent &&
        !!!loading &&
        displayResults === DisplayOption.RAW && (
          <div>
            <pre>{rawData}</pre>
          </div>
        )}
    </div>
  );
};
