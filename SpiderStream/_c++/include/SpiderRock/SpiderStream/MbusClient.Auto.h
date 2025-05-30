// ------------------------------------------------------------------------------------------------------------------------------
//
// Machine generated.  Do not edit directly.
//
// Copyright 2023, SpiderRock Technology
//
// ------------------------------------------------------------------------------------------------------------------------------

#pragma once

#include "stdafx.h"

#include <memory>
#include <initializer_list>

#include "SpiderRock/SpiderStream/DataChannel.h"
#include "SpiderRock/SpiderStream/EventObserver.h"
#include "CoreMessages.Auto.h"
#include "SpiderRock/Net/IPEndPoint.h"

namespace SpiderRock
{
	namespace SpiderStream
	{
		class MbusClient
		{
			class impl;
			std::unique_ptr<impl> impl_;

			SpiderRock::Net::IPEndPoint GetIPEndPoint(DataChannel channel);

		public:
			MbusClient(SysEnvironment environment, in_addr device_address);
			~MbusClient();
			
			enum class Protocol { UDP };

			void MakeCacheRequest(std::initializer_list<MessageType> message_types, std::string auth_token);
			void CreateThreadGroup(Protocol proto, std::initializer_list<DataChannel> channels);
			void Start();

			void RegisterObserver(std::shared_ptr<CreateEventObserver<CurrencyConversion>> observer);
			void RegisterObserver(std::shared_ptr<CreateEventObserver<FutureBookQuote>> observer);
			void RegisterObserver(std::shared_ptr<CreateEventObserver<FuturePrint>> observer);
			void RegisterObserver(std::shared_ptr<CreateEventObserver<FuturePrintMarkup>> observer);
			void RegisterObserver(std::shared_ptr<CreateEventObserver<IndexQuote>> observer);
			void RegisterObserver(std::shared_ptr<CreateEventObserver<LiveImpliedQuote>> observer);
			void RegisterObserver(std::shared_ptr<CreateEventObserver<LiveRevConQuote>> observer);
			void RegisterObserver(std::shared_ptr<CreateEventObserver<LiveSurfaceAtm>> observer);
			void RegisterObserver(std::shared_ptr<CreateEventObserver<OptionCloseMark>> observer);
			void RegisterObserver(std::shared_ptr<CreateEventObserver<OptionExchOrder>> observer);
			void RegisterObserver(std::shared_ptr<CreateEventObserver<OptionExchPrint>> observer);
			void RegisterObserver(std::shared_ptr<CreateEventObserver<OptionMarketSummary>> observer);
			void RegisterObserver(std::shared_ptr<CreateEventObserver<OptionNbboQuote>> observer);
			void RegisterObserver(std::shared_ptr<CreateEventObserver<OptionOpenInterest>> observer);
			void RegisterObserver(std::shared_ptr<CreateEventObserver<OptionPrint>> observer);
			void RegisterObserver(std::shared_ptr<CreateEventObserver<OptionPrint2>> observer);
			void RegisterObserver(std::shared_ptr<CreateEventObserver<OptionPrintMarkup>> observer);
			void RegisterObserver(std::shared_ptr<CreateEventObserver<OptionRiskFactor>> observer);
			void RegisterObserver(std::shared_ptr<CreateEventObserver<ProductDefinitionV2>> observer);
			void RegisterObserver(std::shared_ptr<CreateEventObserver<RootDefinition>> observer);
			void RegisterObserver(std::shared_ptr<CreateEventObserver<SpdrAuctionState>> observer);
			void RegisterObserver(std::shared_ptr<CreateEventObserver<SpreadBookQuote>> observer);
			void RegisterObserver(std::shared_ptr<CreateEventObserver<SpreadDefinition>> observer);
			void RegisterObserver(std::shared_ptr<CreateEventObserver<SpreadExchDefinition>> observer);
			void RegisterObserver(std::shared_ptr<CreateEventObserver<SpreadExchOrder>> observer);
			void RegisterObserver(std::shared_ptr<CreateEventObserver<SpreadExchPrint>> observer);
			void RegisterObserver(std::shared_ptr<CreateEventObserver<StockBookQuote>> observer);
			void RegisterObserver(std::shared_ptr<CreateEventObserver<StockExchImbalanceV2>> observer);
			void RegisterObserver(std::shared_ptr<CreateEventObserver<StockImbalance>> observer);
			void RegisterObserver(std::shared_ptr<CreateEventObserver<StockMarketSummary>> observer);
			void RegisterObserver(std::shared_ptr<CreateEventObserver<StockPrint>> observer);
			void RegisterObserver(std::shared_ptr<CreateEventObserver<StockPrintMarkup>> observer);
			void RegisterObserver(std::shared_ptr<CreateEventObserver<SyntheticExpiryQuote>> observer);
			void RegisterObserver(std::shared_ptr<CreateEventObserver<SyntheticFutureQuote>> observer);
			void RegisterObserver(std::shared_ptr<CreateEventObserver<TickerDefinitionExt>> observer);
			
			void RegisterObserver(std::shared_ptr<ChangeEventObserver<CurrencyConversion>> observer);
			void RegisterObserver(std::shared_ptr<ChangeEventObserver<FutureBookQuote>> observer);
			void RegisterObserver(std::shared_ptr<ChangeEventObserver<FuturePrint>> observer);
			void RegisterObserver(std::shared_ptr<ChangeEventObserver<FuturePrintMarkup>> observer);
			void RegisterObserver(std::shared_ptr<ChangeEventObserver<IndexQuote>> observer);
			void RegisterObserver(std::shared_ptr<ChangeEventObserver<LiveImpliedQuote>> observer);
			void RegisterObserver(std::shared_ptr<ChangeEventObserver<LiveRevConQuote>> observer);
			void RegisterObserver(std::shared_ptr<ChangeEventObserver<LiveSurfaceAtm>> observer);
			void RegisterObserver(std::shared_ptr<ChangeEventObserver<OptionCloseMark>> observer);
			void RegisterObserver(std::shared_ptr<ChangeEventObserver<OptionExchOrder>> observer);
			void RegisterObserver(std::shared_ptr<ChangeEventObserver<OptionExchPrint>> observer);
			void RegisterObserver(std::shared_ptr<ChangeEventObserver<OptionMarketSummary>> observer);
			void RegisterObserver(std::shared_ptr<ChangeEventObserver<OptionNbboQuote>> observer);
			void RegisterObserver(std::shared_ptr<ChangeEventObserver<OptionOpenInterest>> observer);
			void RegisterObserver(std::shared_ptr<ChangeEventObserver<OptionPrint>> observer);
			void RegisterObserver(std::shared_ptr<ChangeEventObserver<OptionPrint2>> observer);
			void RegisterObserver(std::shared_ptr<ChangeEventObserver<OptionPrintMarkup>> observer);
			void RegisterObserver(std::shared_ptr<ChangeEventObserver<OptionRiskFactor>> observer);
			void RegisterObserver(std::shared_ptr<ChangeEventObserver<ProductDefinitionV2>> observer);
			void RegisterObserver(std::shared_ptr<ChangeEventObserver<RootDefinition>> observer);
			void RegisterObserver(std::shared_ptr<ChangeEventObserver<SpdrAuctionState>> observer);
			void RegisterObserver(std::shared_ptr<ChangeEventObserver<SpreadBookQuote>> observer);
			void RegisterObserver(std::shared_ptr<ChangeEventObserver<SpreadDefinition>> observer);
			void RegisterObserver(std::shared_ptr<ChangeEventObserver<SpreadExchDefinition>> observer);
			void RegisterObserver(std::shared_ptr<ChangeEventObserver<SpreadExchOrder>> observer);
			void RegisterObserver(std::shared_ptr<ChangeEventObserver<SpreadExchPrint>> observer);
			void RegisterObserver(std::shared_ptr<ChangeEventObserver<StockBookQuote>> observer);
			void RegisterObserver(std::shared_ptr<ChangeEventObserver<StockExchImbalanceV2>> observer);
			void RegisterObserver(std::shared_ptr<ChangeEventObserver<StockImbalance>> observer);
			void RegisterObserver(std::shared_ptr<ChangeEventObserver<StockMarketSummary>> observer);
			void RegisterObserver(std::shared_ptr<ChangeEventObserver<StockPrint>> observer);
			void RegisterObserver(std::shared_ptr<ChangeEventObserver<StockPrintMarkup>> observer);
			void RegisterObserver(std::shared_ptr<ChangeEventObserver<SyntheticExpiryQuote>> observer);
			void RegisterObserver(std::shared_ptr<ChangeEventObserver<SyntheticFutureQuote>> observer);
			void RegisterObserver(std::shared_ptr<ChangeEventObserver<TickerDefinitionExt>> observer);
			
			void RegisterObserver(std::shared_ptr<UpdateEventObserver<CurrencyConversion>> observer);
			void RegisterObserver(std::shared_ptr<UpdateEventObserver<FutureBookQuote>> observer);
			void RegisterObserver(std::shared_ptr<UpdateEventObserver<FuturePrint>> observer);
			void RegisterObserver(std::shared_ptr<UpdateEventObserver<FuturePrintMarkup>> observer);
			void RegisterObserver(std::shared_ptr<UpdateEventObserver<IndexQuote>> observer);
			void RegisterObserver(std::shared_ptr<UpdateEventObserver<LiveImpliedQuote>> observer);
			void RegisterObserver(std::shared_ptr<UpdateEventObserver<LiveRevConQuote>> observer);
			void RegisterObserver(std::shared_ptr<UpdateEventObserver<LiveSurfaceAtm>> observer);
			void RegisterObserver(std::shared_ptr<UpdateEventObserver<OptionCloseMark>> observer);
			void RegisterObserver(std::shared_ptr<UpdateEventObserver<OptionExchOrder>> observer);
			void RegisterObserver(std::shared_ptr<UpdateEventObserver<OptionExchPrint>> observer);
			void RegisterObserver(std::shared_ptr<UpdateEventObserver<OptionMarketSummary>> observer);
			void RegisterObserver(std::shared_ptr<UpdateEventObserver<OptionNbboQuote>> observer);
			void RegisterObserver(std::shared_ptr<UpdateEventObserver<OptionOpenInterest>> observer);
			void RegisterObserver(std::shared_ptr<UpdateEventObserver<OptionPrint>> observer);
			void RegisterObserver(std::shared_ptr<UpdateEventObserver<OptionPrint2>> observer);
			void RegisterObserver(std::shared_ptr<UpdateEventObserver<OptionPrintMarkup>> observer);
			void RegisterObserver(std::shared_ptr<UpdateEventObserver<OptionRiskFactor>> observer);
			void RegisterObserver(std::shared_ptr<UpdateEventObserver<ProductDefinitionV2>> observer);
			void RegisterObserver(std::shared_ptr<UpdateEventObserver<RootDefinition>> observer);
			void RegisterObserver(std::shared_ptr<UpdateEventObserver<SpdrAuctionState>> observer);
			void RegisterObserver(std::shared_ptr<UpdateEventObserver<SpreadBookQuote>> observer);
			void RegisterObserver(std::shared_ptr<UpdateEventObserver<SpreadDefinition>> observer);
			void RegisterObserver(std::shared_ptr<UpdateEventObserver<SpreadExchDefinition>> observer);
			void RegisterObserver(std::shared_ptr<UpdateEventObserver<SpreadExchOrder>> observer);
			void RegisterObserver(std::shared_ptr<UpdateEventObserver<SpreadExchPrint>> observer);
			void RegisterObserver(std::shared_ptr<UpdateEventObserver<StockBookQuote>> observer);
			void RegisterObserver(std::shared_ptr<UpdateEventObserver<StockExchImbalanceV2>> observer);
			void RegisterObserver(std::shared_ptr<UpdateEventObserver<StockImbalance>> observer);
			void RegisterObserver(std::shared_ptr<UpdateEventObserver<StockMarketSummary>> observer);
			void RegisterObserver(std::shared_ptr<UpdateEventObserver<StockPrint>> observer);
			void RegisterObserver(std::shared_ptr<UpdateEventObserver<StockPrintMarkup>> observer);
			void RegisterObserver(std::shared_ptr<UpdateEventObserver<SyntheticExpiryQuote>> observer);
			void RegisterObserver(std::shared_ptr<UpdateEventObserver<SyntheticFutureQuote>> observer);
			void RegisterObserver(std::shared_ptr<UpdateEventObserver<TickerDefinitionExt>> observer);			
		};
	}
}
