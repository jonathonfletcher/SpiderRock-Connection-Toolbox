# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: SpreadExchData/SpreadExchDefinition.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2
from google.protobuf import timestamp_pb2 as google_dot_protobuf_dot_timestamp__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n)SpreadExchData/SpreadExchDefinition.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\x1a\x1fgoogle/protobuf/timestamp.proto\"\x9c\x04\n\x14SpreadExchDefinition\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12<\n\x04pkey\x18\x02 \x01(\x0b\x32..spiderrock.protobuf.SpreadExchDefinition.PKey\x12-\n\ttimestamp\x18i \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12<\n\x04legs\x18\x64 \x03(\x0b\x32..spiderrock.protobuf.SpreadExchDefinition.Legs\x1aG\n\x04PKey\x12*\n\x04\x65xch\x18\n \x01(\x0e\x32\x1c.spiderrock.protobuf.OptExch\x12\x13\n\x0b\x65xch_spr_iD\x18\x0b \x01(\t\x1a\xda\x01\n\x04Legs\x12\x33\n\x0bleg_sec_key\x18\x65 \x01(\x0b\x32\x1e.spiderrock.protobuf.OptionKey\x12\x36\n\x0cleg_sec_type\x18\x66 \x01(\x0e\x32 .spiderrock.protobuf.SpdrKeyType\x12.\n\x08leg_side\x18g \x01(\x0e\x32\x1c.spiderrock.protobuf.BuySell\x12\x11\n\tleg_ratio\x18h \x01(\r\x12\x11\n\tref_delta\x18j \x01(\x02\x12\x0f\n\x07ref_prc\x18k \x01(\x01\x62\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'SpreadExchData.SpreadExchDefinition_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_SPREADEXCHDEFINITION']._serialized_start=125
  _globals['_SPREADEXCHDEFINITION']._serialized_end=665
  _globals['_SPREADEXCHDEFINITION_PKEY']._serialized_start=373
  _globals['_SPREADEXCHDEFINITION_PKEY']._serialized_end=444
  _globals['_SPREADEXCHDEFINITION_LEGS']._serialized_start=447
  _globals['_SPREADEXCHDEFINITION_LEGS']._serialized_end=665
# @@protoc_insertion_point(module_scope)
