# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: OptSurface/HistoricalVolatilities.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2
from google.protobuf import timestamp_pb2 as google_dot_protobuf_dot_timestamp__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n\'OptSurface/HistoricalVolatilities.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\x1a\x1fgoogle/protobuf/timestamp.proto\"\xd7\x05\n\x16HistoricalVolatilities\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12>\n\x04pkey\x18\x02 \x01(\x0b\x32\x30.spiderrock.protobuf.HistoricalVolatilities.PKey\x12\x0c\n\x04\x64\x61te\x18\x64 \x01(\t\x12\x13\n\x0bsecurity_iD\x18g \x01(\x05\x12\r\n\x05value\x18j \x01(\x02\x12\r\n\x05mv_5d\x18m \x01(\x02\x12\r\n\x05sd_5d\x18p \x01(\x02\x12\x0e\n\x06mv_10d\x18s \x01(\x02\x12\x0e\n\x06sd_10d\x18v \x01(\x02\x12\x0e\n\x06mv_21d\x18y \x01(\x02\x12\x0e\n\x06sd_21d\x18| \x01(\x02\x12\x0e\n\x06mv_42d\x18\x7f \x01(\x02\x12\x0f\n\x06sd_42d\x18\x82\x01 \x01(\x02\x12\x0f\n\x06mv_63d\x18\x85\x01 \x01(\x02\x12\x0f\n\x06sd_63d\x18\x88\x01 \x01(\x02\x12\x0f\n\x06mv_84d\x18\x8b\x01 \x01(\x02\x12\x0f\n\x06sd_84d\x18\x8e\x01 \x01(\x02\x12\x10\n\x07mv_105d\x18\x91\x01 \x01(\x02\x12\x10\n\x07sd_105d\x18\x94\x01 \x01(\x02\x12\x10\n\x07mv_126d\x18\x97\x01 \x01(\x02\x12\x10\n\x07sd_126d\x18\x9a\x01 \x01(\x02\x12\x10\n\x07mv_189d\x18\x9d\x01 \x01(\x02\x12\x10\n\x07sd_189d\x18\xa0\x01 \x01(\x02\x12\x10\n\x07mv_252d\x18\xa3\x01 \x01(\x02\x12\x10\n\x07sd_252d\x18\xa6\x01 \x01(\x02\x12\x10\n\x07mv_378d\x18\xa9\x01 \x01(\x02\x12\x10\n\x07sd_378d\x18\xac\x01 \x01(\x02\x12\x10\n\x07mv_504d\x18\xaf\x01 \x01(\x02\x12\x10\n\x07sd_504d\x18\xb2\x01 \x01(\x02\x12.\n\ttimestamp\x18\xb5\x01 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x1aK\n\x04PKey\x12.\n\x06ticker\x18\n \x01(\x0b\x32\x1e.spiderrock.protobuf.TickerKey\x12\x13\n\x0bwindow_type\x18\x0b \x01(\tb\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'OptSurface.HistoricalVolatilities_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_HISTORICALVOLATILITIES']._serialized_start=123
  _globals['_HISTORICALVOLATILITIES']._serialized_end=850
  _globals['_HISTORICALVOLATILITIES_PKEY']._serialized_start=775
  _globals['_HISTORICALVOLATILITIES_PKEY']._serialized_end=850
# @@protoc_insertion_point(module_scope)