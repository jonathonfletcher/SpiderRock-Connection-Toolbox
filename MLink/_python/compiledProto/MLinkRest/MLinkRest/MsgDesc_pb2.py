# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: MLinkRest/MsgDesc.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n\x17MLinkRest/MsgDesc.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\"\xe6\x03\n\x07MsgDesc\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12\x0c\n\x04name\x18\x64 \x01(\t\x12\r\n\x05m_num\x18g \x01(\r\x12\x13\n\x0bschema_hash\x18j \x01(\t\x12\x0f\n\x07\x61\x63tions\x18m \x01(\t\x12,\n\x08has_tKey\x18p \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12,\n\x08has_eKey\x18s \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12,\n\x08has_oKey\x18v \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12*\n\x06has_cF\x18y \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x30\n\x07m_token\x18| \x01(\x0e\x32\x1f.spiderrock.protobuf.MLinkToken\x12\x0c\n\x04\x64\x65sc\x18\x7f \x01(\t\x12\x17\n\x0epri_time_field\x18\x82\x01 \x01(\t\x12\x17\n\x0esec_time_field\x18\x85\x01 \x01(\t\x12\x1c\n\x13\x64\x65\x66\x61ult_grid_fields\x18\x88\x01 \x01(\t\x12\x1d\n\x14static_filter_fields\x18\x8b\x01 \x01(\tb\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'MLinkRest.MsgDesc_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_MSGDESC']._serialized_start=74
  _globals['_MSGDESC']._serialized_end=560
# @@protoc_insertion_point(module_scope)
