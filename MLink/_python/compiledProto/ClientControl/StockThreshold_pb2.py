# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: ClientControl/StockThreshold.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2
from google.protobuf import timestamp_pb2 as google_dot_protobuf_dot_timestamp__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n\"ClientControl/StockThreshold.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\x1a\x1fgoogle/protobuf/timestamp.proto\"\xb5\x02\n\x0eStockThreshold\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12\x36\n\x04pkey\x18\x02 \x01(\x0b\x32(.spiderrock.protobuf.StockThreshold.PKey\x12\x32\n\x0ethreshold_flag\x18\x64 \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x16\n\x0ethreshold_days\x18g \x01(\x05\x12\x32\n\x0ethreshold_date\x18j \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x1a\x36\n\x04PKey\x12.\n\x06ticker\x18\n \x01(\x0b\x32\x1e.spiderrock.protobuf.TickerKeyb\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'ClientControl.StockThreshold_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_STOCKTHRESHOLD']._serialized_start=118
  _globals['_STOCKTHRESHOLD']._serialized_end=427
  _globals['_STOCKTHRESHOLD_PKEY']._serialized_start=373
  _globals['_STOCKTHRESHOLD_PKEY']._serialized_end=427
# @@protoc_insertion_point(module_scope)
