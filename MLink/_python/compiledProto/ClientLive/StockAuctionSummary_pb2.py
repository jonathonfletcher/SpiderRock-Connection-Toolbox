# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: ClientLive/StockAuctionSummary.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2
from google.protobuf import timestamp_pb2 as google_dot_protobuf_dot_timestamp__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n$ClientLive/StockAuctionSummary.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\x1a\x1fgoogle/protobuf/timestamp.proto\"\x95\x07\n\x13StockAuctionSummary\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12;\n\x04pkey\x18\x02 \x01(\x0b\x32-.spiderrock.protobuf.StockAuctionSummary.PKey\x12\x15\n\rauction_price\x18\x64 \x01(\x02\x12\x16\n\x0e\x61uction_volume\x18g \x01(\x05\x12\x32\n\x0c\x61uction_date\x18j \x01(\x0b\x32\x1c.spiderrock.protobuf.DateKey\x12\x16\n\x0e\x61uction_price1\x18m \x01(\x02\x12\x17\n\x0f\x61uction_volume1\x18p \x01(\x05\x12\x33\n\rauction_date1\x18s \x01(\x0b\x32\x1c.spiderrock.protobuf.DateKey\x12\x16\n\x0e\x61uction_price2\x18v \x01(\x02\x12\x17\n\x0f\x61uction_volume2\x18y \x01(\x05\x12\x33\n\rauction_date2\x18| \x01(\x0b\x32\x1c.spiderrock.protobuf.DateKey\x12\x16\n\x0e\x61uction_price3\x18\x7f \x01(\x02\x12\x18\n\x0f\x61uction_volume3\x18\x82\x01 \x01(\x05\x12\x34\n\rauction_date3\x18\x85\x01 \x01(\x0b\x32\x1c.spiderrock.protobuf.DateKey\x12\x17\n\x0e\x61uction_price4\x18\x88\x01 \x01(\x02\x12\x18\n\x0f\x61uction_volume4\x18\x8b\x01 \x01(\x05\x12\x34\n\rauction_date4\x18\x8e\x01 \x01(\x0b\x32\x1c.spiderrock.protobuf.DateKey\x12\x17\n\x0e\x61uction_price5\x18\x91\x01 \x01(\x02\x12\x18\n\x0f\x61uction_volume5\x18\x94\x01 \x01(\x05\x12\x34\n\rauction_date5\x18\x97\x01 \x01(\x0b\x32\x1c.spiderrock.protobuf.DateKey\x12.\n\ttimestamp\x18\x9a\x01 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x1as\n\x04PKey\x12.\n\x06ticker\x18\n \x01(\x0b\x32\x1e.spiderrock.protobuf.TickerKey\x12;\n\x0c\x61uction_type\x18\x0b \x01(\x0e\x32%.spiderrock.protobuf.StockAuctionTypeb\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'ClientLive.StockAuctionSummary_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_STOCKAUCTIONSUMMARY']._serialized_start=120
  _globals['_STOCKAUCTIONSUMMARY']._serialized_end=1037
  _globals['_STOCKAUCTIONSUMMARY_PKEY']._serialized_start=922
  _globals['_STOCKAUCTIONSUMMARY_PKEY']._serialized_end=1037
# @@protoc_insertion_point(module_scope)
