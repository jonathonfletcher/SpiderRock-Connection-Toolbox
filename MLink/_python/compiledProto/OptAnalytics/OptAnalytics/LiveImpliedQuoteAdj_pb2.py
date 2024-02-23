# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: OptAnalytics/LiveImpliedQuoteAdj.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2
from google.protobuf import timestamp_pb2 as google_dot_protobuf_dot_timestamp__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n&OptAnalytics/LiveImpliedQuoteAdj.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\x1a\x1fgoogle/protobuf/timestamp.proto\"\xa0\x07\n\x13LiveImpliedQuoteAdj\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12;\n\x04pkey\x18\x02 \x01(\x0b\x32-.spiderrock.protobuf.LiveImpliedQuoteAdj.PKey\x12.\n\x06ticker\x18\x64 \x01(\x0b\x32\x1e.spiderrock.protobuf.TickerKey\x12\x0c\n\x04uprc\x18g \x01(\x02\x12\r\n\x05years\x18j \x01(\x02\x12\x0c\n\x04rate\x18m \x01(\x02\x12\x0c\n\x04sdiv\x18p \x01(\x02\x12\x0c\n\x04\x64\x64iv\x18s \x01(\x02\x12\x0c\n\x04obid\x18v \x01(\x02\x12\x0c\n\x04oask\x18y \x01(\x02\x12\x0c\n\x04obiv\x18| \x01(\x02\x12\x0c\n\x04oaiv\x18\x7f \x01(\x02\x12\r\n\x04satm\x18\x82\x01 \x01(\x02\x12\r\n\x04smny\x18\x85\x01 \x01(\x02\x12\r\n\x04svol\x18\x88\x01 \x01(\x02\x12\r\n\x04sprc\x18\x8b\x01 \x01(\x02\x12\r\n\x04smrk\x18\x8e\x01 \x01(\x02\x12\x11\n\x08ve_slope\x18\x91\x01 \x01(\x02\x12\x0b\n\x02\x64\x65\x18\x94\x01 \x01(\x02\x12\x0b\n\x02ga\x18\x97\x01 \x01(\x02\x12\x0b\n\x02th\x18\x9a\x01 \x01(\x02\x12\x0b\n\x02ve\x18\x9d\x01 \x01(\x02\x12\x0b\n\x02va\x18\xa0\x01 \x01(\x02\x12\x0b\n\x02vo\x18\xa3\x01 \x01(\x02\x12\x0b\n\x02ro\x18\xa6\x01 \x01(\x02\x12\x0b\n\x02ph\x18\xa9\x01 \x01(\x02\x12\x11\n\x08\x64\x65_decay\x18\xac\x01 \x01(\x02\x12\r\n\x04up50\x18\xaf\x01 \x01(\x02\x12\r\n\x04\x64n50\x18\xb2\x01 \x01(\x02\x12\r\n\x04up15\x18\xb5\x01 \x01(\x02\x12\r\n\x04\x64n15\x18\xb8\x01 \x01(\x02\x12\r\n\x04up06\x18\xbb\x01 \x01(\x02\x12\r\n\x04\x64n08\x18\xbe\x01 \x01(\x02\x12\x11\n\x08syn_spot\x18\xc1\x01 \x01(\x01\x12\x37\n\nprice_type\x18\xc4\x01 \x01(\x0e\x32\".spiderrock.protobuf.CalcPriceType\x12\x11\n\x08\x63\x61lc_err\x18\xc7\x01 \x01(\t\x12\x35\n\x0b\x63\x61lc_source\x18\xca\x01 \x01(\x0e\x32\x1f.spiderrock.protobuf.CalcSource\x12\x39\n\x10u_prc_adj_result\x18\xcd\x01 \x01(\x0e\x32\x1e.spiderrock.protobuf.AdjResult\x12.\n\ttimestamp\x18\xd0\x01 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x1a\x34\n\x04PKey\x12,\n\x04okey\x18\n \x01(\x0b\x32\x1e.spiderrock.protobuf.OptionKeyb\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'OptAnalytics.LiveImpliedQuoteAdj_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_LIVEIMPLIEDQUOTEADJ']._serialized_start=122
  _globals['_LIVEIMPLIEDQUOTEADJ']._serialized_end=1050
  _globals['_LIVEIMPLIEDQUOTEADJ_PKEY']._serialized_start=998
  _globals['_LIVEIMPLIEDQUOTEADJ_PKEY']._serialized_end=1050
# @@protoc_insertion_point(module_scope)
