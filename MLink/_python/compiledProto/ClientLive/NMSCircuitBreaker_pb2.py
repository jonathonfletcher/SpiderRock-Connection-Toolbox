# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: ClientLive/NMSCircuitBreaker.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2
from google.protobuf import timestamp_pb2 as google_dot_protobuf_dot_timestamp__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n\"ClientLive/NMSCircuitBreaker.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\x1a\x1fgoogle/protobuf/timestamp.proto\"\x98\x02\n\x11NMSCircuitBreaker\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12\x39\n\x04pkey\x18\x02 \x01(\x0b\x32+.spiderrock.protobuf.NMSCircuitBreaker.PKey\x12\x0e\n\x06level1\x18\x64 \x01(\x02\x12\x0e\n\x06level2\x18g \x01(\x02\x12\x0e\n\x06level3\x18j \x01(\x02\x12\x15\n\rcurrent_level\x18m \x01(\x05\x12-\n\ttimestamp\x18p \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x1a\x1d\n\x04PKey\x12\x15\n\rmarket_center\x18\n \x01(\tb\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'ClientLive.NMSCircuitBreaker_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_NMSCIRCUITBREAKER']._serialized_start=118
  _globals['_NMSCIRCUITBREAKER']._serialized_end=398
  _globals['_NMSCIRCUITBREAKER_PKEY']._serialized_start=369
  _globals['_NMSCIRCUITBREAKER_PKEY']._serialized_end=398
# @@protoc_insertion_point(module_scope)
