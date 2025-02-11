# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: ClientTrading/SpdrSweepExchDetail.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2
from google.protobuf import timestamp_pb2 as google_dot_protobuf_dot_timestamp__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n\'ClientTrading/SpdrSweepExchDetail.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\x1a\x1fgoogle/protobuf/timestamp.proto\"\x9c\x06\n\x13SpdrSweepExchDetail\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12;\n\x04pkey\x18\x02 \x01(\x0b\x32-.spiderrock.protobuf.SpdrSweepExchDetail.PKey\x12\r\n\x05\x61\x63\x63nt\x18\x64 \x01(\t\x12\x13\n\x0b\x63lient_firm\x18g \x01(\t\x12/\n\x07sec_key\x18j \x01(\x0b\x32\x1e.spiderrock.protobuf.OptionKey\x12\x32\n\x08sec_type\x18m \x01(\x0e\x32 .spiderrock.protobuf.SpdrKeyType\x12\x30\n\norder_side\x18p \x01(\x0e\x32\x1c.spiderrock.protobuf.BuySell\x12\x19\n\x11parent_order_size\x18s \x01(\x05\x12\x1a\n\x12parent_limit_price\x18v \x01(\x01\x12\x10\n\x08\x65xch_bid\x18y \x01(\x01\x12\x10\n\x08\x65xch_ask\x18| \x01(\x01\x12\x13\n\x0b\x65xch_bid_sz\x18\x7f \x01(\x05\x12\x14\n\x0b\x65xch_ask_sz\x18\x82\x01 \x01(\x05\x12\x12\n\tcl_ord_id\x18\x85\x01 \x01(\x03\x12\x12\n\tchild_prc\x18\x88\x01 \x01(\x01\x12\x13\n\nchild_size\x18\x8b\x01 \x01(\x05\x12\x17\n\x0emax_child_size\x18\x8e\x01 \x01(\x05\x12\x30\n\x0bis_iSOChild\x18\x91\x01 \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x37\n\x0c\x63hild_result\x18\x94\x01 \x01(\x0e\x32 .spiderrock.protobuf.SweepResult\x12\x16\n\rnet_timestamp\x18\x97\x01 \x01(\x03\x12.\n\ttimestamp\x18\x9a\x01 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x1aI\n\x04PKey\x12\x15\n\rparent_number\x18\n \x01(\x03\x12\x18\n\x10trigger_group_id\x18\x0b \x01(\x03\x12\x10\n\x08\x65xchange\x18\x0c \x01(\tb\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'ClientTrading.SpdrSweepExchDetail_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_SPDRSWEEPEXCHDETAIL']._serialized_start=123
  _globals['_SPDRSWEEPEXCHDETAIL']._serialized_end=919
  _globals['_SPDRSWEEPEXCHDETAIL_PKEY']._serialized_start=846
  _globals['_SPDRSWEEPEXCHDETAIL_PKEY']._serialized_end=919
# @@protoc_insertion_point(module_scope)
