# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: FutMktData/FuturePrint.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2
from google.protobuf import timestamp_pb2 as google_dot_protobuf_dot_timestamp__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n\x1c\x46utMktData/FuturePrint.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\x1a\x1fgoogle/protobuf/timestamp.proto\"\xd7\x04\n\x0b\x46uturePrint\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12\x33\n\x04pkey\x18\x02 \x01(\x0b\x32%.spiderrock.protobuf.FuturePrint.PKey\x12.\n\x08prt_exch\x18\x64 \x01(\x0e\x32\x1c.spiderrock.protobuf.FutExch\x12\x10\n\x08prt_size\x18g \x01(\x05\x12\x11\n\tprt_price\x18j \x01(\x01\x12\x17\n\x0fprt_cluster_num\x18m \x01(\x05\x12\x18\n\x10prt_cluster_size\x18p \x01(\x05\x12\x10\n\x08prt_type\x18s \x01(\x05\x12\x12\n\nprt_orders\x18v \x01(\r\x12\x10\n\x08prt_quan\x18y \x01(\x05\x12\x12\n\nprt_volume\x18| \x01(\x05\x12\x0b\n\x03\x62id\x18\x7f \x01(\x02\x12\x0c\n\x03\x61sk\x18\x82\x01 \x01(\x02\x12\x0c\n\x03\x62sz\x18\x85\x01 \x01(\x05\x12\x0c\n\x03\x61sz\x18\x88\x01 \x01(\x05\x12\x0c\n\x03\x61ge\x18\x8b\x01 \x01(\x02\x12/\n\x08prt_side\x18\x8e\x01 \x01(\x0e\x32\x1c.spiderrock.protobuf.PrtSide\x12\x16\n\rprt_timestamp\x18\x91\x01 \x01(\x03\x12\x16\n\rnet_timestamp\x18\x94\x01 \x01(\x03\x12.\n\ttimestamp\x18\x97\x01 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x1a\x34\n\x04PKey\x12,\n\x04\x66key\x18\n \x01(\x0b\x32\x1e.spiderrock.protobuf.ExpiryKeyb\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'FutMktData.FuturePrint_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_FUTUREPRINT']._serialized_start=112
  _globals['_FUTUREPRINT']._serialized_end=711
  _globals['_FUTUREPRINT_PKEY']._serialized_start=659
  _globals['_FUTUREPRINT_PKEY']._serialized_end=711
# @@protoc_insertion_point(module_scope)