# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: ClientControl/UserDividendOverride.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2
from google.protobuf import timestamp_pb2 as google_dot_protobuf_dot_timestamp__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n(ClientControl/UserDividendOverride.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\x1a\x1fgoogle/protobuf/timestamp.proto\"\xc0\x05\n\x14UserDividendOverride\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12<\n\x04pkey\x18\x02 \x01(\x0b\x32..spiderrock.protobuf.UserDividendOverride.PKey\x12-\n\ttimestamp\x18\x64 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12\x0c\n\x04text\x18g \x01(\t\x12\x32\n\nmerge_type\x18j \x01(\x0e\x32\x1e.spiderrock.protobuf.MergeType\x12\x43\n\x08\x64\x61te_amt\x18m \x03(\x0b\x32\x31.spiderrock.protobuf.UserDividendOverride.DateAmt\x1a\x85\x01\n\x04PKey\x12.\n\x06ticker\x18\n \x01(\x0b\x32\x1e.spiderrock.protobuf.TickerKey\x12\x13\n\x0b\x63lient_firm\x18\x0b \x01(\t\x12\x38\n\rdividend_slot\x18\x0c \x01(\x0e\x32!.spiderrock.protobuf.DividendSlot\x1a\xf6\x01\n\x07\x44\x61teAmt\x12.\n\x08\x64iv_date\x18p \x01(\x0b\x32\x1c.spiderrock.protobuf.DateKey\x12\x11\n\tdiv_value\x18s \x01(\x02\x12\x14\n\x0c\x64iv_currency\x18v \x01(\t\x12.\n\x08\x64iv_kind\x18y \x01(\x0e\x32\x1c.spiderrock.protobuf.DivKind\x12\x32\n\ndiv_source\x18| \x01(\x0e\x32\x1e.spiderrock.protobuf.DivSource\x12.\n\x08\x64iv_freq\x18\x7f \x01(\x0e\x32\x1c.spiderrock.protobuf.DivFreqb\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'ClientControl.UserDividendOverride_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_USERDIVIDENDOVERRIDE']._serialized_start=124
  _globals['_USERDIVIDENDOVERRIDE']._serialized_end=828
  _globals['_USERDIVIDENDOVERRIDE_PKEY']._serialized_start=446
  _globals['_USERDIVIDENDOVERRIDE_PKEY']._serialized_end=579
  _globals['_USERDIVIDENDOVERRIDE_DATEAMT']._serialized_start=582
  _globals['_USERDIVIDENDOVERRIDE_DATEAMT']._serialized_end=828
# @@protoc_insertion_point(module_scope)
