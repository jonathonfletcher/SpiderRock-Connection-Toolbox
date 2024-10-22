# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: SRATS/AuctionNoticeSN.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2
from google.protobuf import timestamp_pb2 as google_dot_protobuf_dot_timestamp__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n\x1bSRATS/AuctionNoticeSN.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\x1a\x1fgoogle/protobuf/timestamp.proto\"\xb2\x0e\n\x0f\x41uctionNoticeSN\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12\x37\n\x04pkey\x18\x02 \x01(\x0b\x32).spiderrock.protobuf.AuctionNoticeSN.PKey\x12.\n\x06ticker\x18\x64 \x01(\x0b\x32\x1e.spiderrock.protobuf.TickerKey\x12\x30\n\ntrade_date\x18\x65 \x01(\x0b\x32\x1c.spiderrock.protobuf.DateKey\x12\x36\n\x0c\x61uction_type\x18\x66 \x01(\x0e\x32 .spiderrock.protobuf.AuctionType\x12\x38\n\rauction_event\x18g \x01(\x0e\x32!.spiderrock.protobuf.AuctionEvent\x12\x16\n\x0esrc_auction_iD\x18h \x01(\t\x12\x18\n\x10src_auction_type\x18i \x01(\t\x12:\n\x0e\x61uction_source\x18j \x01(\x0e\x32\".spiderrock.protobuf.AuctionSource\x12\x33\n\x0fis_test_auction\x18k \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x31\n\rcontains_flex\x18l \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x12\n\nshort_code\x18m \x01(\t\x12\x10\n\x08industry\x18n \x01(\t\x12\x34\n\x0bsymbol_type\x18o \x01(\x0e\x32\x1f.spiderrock.protobuf.SymbolType\x12\x17\n\x0fu_avg_daily_vlm\x18p \x01(\x02\x12,\n\x04root\x18q \x01(\x0b\x32\x1e.spiderrock.protobuf.TickerKey\x12,\n\x06\x65xpiry\x18r \x01(\x0b\x32\x1c.spiderrock.protobuf.DateKey\x12\x0e\n\x06strike\x18s \x01(\x01\x12/\n\tcust_side\x18t \x01(\x0e\x32\x1c.spiderrock.protobuf.BuySell\x12\x10\n\x08\x63ust_qty\x18u \x01(\x05\x12\x10\n\x08\x63ust_prc\x18v \x01(\x01\x12\x30\n\x0chas_cust_prc\x18w \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x35\n\x0e\x63ust_firm_type\x18x \x01(\x0e\x32\x1d.spiderrock.protobuf.FirmType\x12\x17\n\x0f\x63ust_agent_mPID\x18y \x01(\t\x12\x18\n\x10\x63ust_client_firm\x18z \x01(\t\x12\x18\n\x10\x63omm_enhancement\x18{ \x01(\x02\x12\x34\n\x10\x63ust_comm_paying\x18| \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x37\n\rcust_qty_cond\x18} \x01(\x0e\x32 .spiderrock.protobuf.CustQtyCond\x12\x18\n\x10\x61uction_duration\x18~ \x01(\x05\x12\r\n\x05u_bid\x18\x7f \x01(\x01\x12\x0e\n\x05u_ask\x18\x80\x01 \x01(\x01\x12\x0f\n\x06i_days\x18\x81\x01 \x01(\x01\x12\x10\n\x07i_years\x18\x82\x01 \x01(\x01\x12\x13\n\nmoney_rate\x18\x83\x01 \x01(\x01\x12\x10\n\x07\x64\x64iv_pv\x18\x84\x01 \x01(\x01\x12\x32\n\rhas_est_dDivs\x18\x85\x01 \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x0e\n\x05s_vol\x18\x86\x01 \x01(\x01\x12\x14\n\x0brc_eEx_prem\x18\x87\x01 \x01(\x01\x12\x12\n\tstrike_pv\x18\x88\x01 \x01(\x01\x12\x16\n\rsrc_timestamp\x18\x89\x01 \x01(\x03\x12\x16\n\rnet_timestamp\x18\x8a\x01 \x01(\x03\x12.\n\ttimestamp\x18\x8b\x01 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12\x41\n\x11include_sRNetwork\x18\x8c\x01 \x01(\x0e\x32%.spiderrock.protobuf.InclExclDisclose\x12Z\n\x16\x64irected_counter_party\x18\x8d\x01 \x03(\x0b\x32\x39.spiderrock.protobuf.AuctionNoticeSN.DirectedCounterParty\x1a\x1d\n\x04PKey\x12\x15\n\rnotice_number\x18\n \x01(\x03\x1a\x9c\x01\n\x14\x44irectedCounterParty\x12\x14\n\x0b\x63lient_firm\x18\x8e\x01 \x01(\t\x12\x39\n\tincl_excl\x18\x8f\x01 \x01(\x0e\x32%.spiderrock.protobuf.InclExclDisclose\x12\x33\n\x0eis_comm_paying\x18\x90\x01 \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNob\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'SRATS.AuctionNoticeSN_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_AUCTIONNOTICESN']._serialized_start=111
  _globals['_AUCTIONNOTICESN']._serialized_end=1953
  _globals['_AUCTIONNOTICESN_PKEY']._serialized_start=1765
  _globals['_AUCTIONNOTICESN_PKEY']._serialized_end=1794
  _globals['_AUCTIONNOTICESN_DIRECTEDCOUNTERPARTY']._serialized_start=1797
  _globals['_AUCTIONNOTICESN_DIRECTEDCOUNTERPARTY']._serialized_end=1953
# @@protoc_insertion_point(module_scope)
