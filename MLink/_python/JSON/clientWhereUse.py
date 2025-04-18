import asyncio
import json
import time

import websockets
import nest_asyncio
import threading
import datetime
from collections import deque
nest_asyncio.apply()

uriJson = "wss://mlink-live.nms.saturn.spiderrockconnect.com/mlink/json"
authentication_key = "ApiKey"

async def recv_msg(websocket):
    buffer = await websocket.recv()
    result = json.loads(buffer)
    print(result)
    

    return True

async def query_mlink(authentication_key):
    retry = True
    while retry:
        try:
            async with websockets.connect(uriJson, 
                                          additional_headers={"Authorization": f"Bearer {authentication_key}"},
                                           ping_timeout=None) as websocket:
                msg = {
                    "header": {
                        "mTyp": "MLinkStream"
                    },
                    "message": {
                        "queryLabel": "ExampleStockNbbo",
                        "activeLatency": 1, #you can stream AAPL with minimum latency
                        "msgName": "OptionNbboQuote",
                        "view":"bidprice|askprice",
                        "where":"okey.tk:eq:SPX & okey.xx:gt:3500 & okey.xx:lt:4500"
                    }
                }

                t = time.time_ns()
                tstr = '.'.join([time.strftime("%Y-%m-%d %H:%M:%S", time.gmtime(t / 1000000000)), "%06d" % ((t / 1000) % 1000000)])
                msg['header']['sTim'] = tstr
                msg['header']['encT'] = tstr
                smsg = json.dumps(msg)
                await websocket.send(smsg)
                notDone = True
                while notDone:
                    notDone = await recv_msg(websocket)
        except asyncio.exceptions.TimeoutError:
            print("timeout occurred, retrying...")


if __name__ == "__main__":
    asyncio.run(query_mlink(authentication_key))