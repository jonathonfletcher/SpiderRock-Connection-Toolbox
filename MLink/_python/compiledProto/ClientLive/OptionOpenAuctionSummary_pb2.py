# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: ClientLive/OptionOpenAuctionSummary.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2
from google.protobuf import timestamp_pb2 as google_dot_protobuf_dot_timestamp__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n)ClientLive/OptionOpenAuctionSummary.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\x1a\x1fgoogle/protobuf/timestamp.proto\"\xfa\x02\n\x18OptionOpenAuctionSummary\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12@\n\x04pkey\x18\x02 \x01(\x0b\x32\x32.spiderrock.protobuf.OptionOpenAuctionSummary.PKey\x12:\n\x0c\x61uction_type\x18\x64 \x01(\x0e\x32$.spiderrock.protobuf.OpenAuctionType\x12\x0b\n\x03prc\x18g \x01(\x02\x12\x0b\n\x03qty\x18j \x01(\x05\x12\x15\n\rsrc_timestamp\x18m \x01(\x03\x12\x15\n\rnet_timestamp\x18p \x01(\x03\x12-\n\ttimestamp\x18s \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x1a\x34\n\x04PKey\x12,\n\x04okey\x18\n \x01(\x0b\x32\x1e.spiderrock.protobuf.OptionKeyb\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'ClientLive.OptionOpenAuctionSummary_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_OPTIONOPENAUCTIONSUMMARY']._serialized_start=125
  _globals['_OPTIONOPENAUCTIONSUMMARY']._serialized_end=503
  _globals['_OPTIONOPENAUCTIONSUMMARY_PKEY']._serialized_start=451
  _globals['_OPTIONOPENAUCTIONSUMMARY_PKEY']._serialized_end=503
# @@protoc_insertion_point(module_scope)
