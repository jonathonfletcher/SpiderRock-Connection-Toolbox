# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: ClientControl/BookControl.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2
from google.protobuf import timestamp_pb2 as google_dot_protobuf_dot_timestamp__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n\x1f\x43lientControl/BookControl.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\x1a\x1fgoogle/protobuf/timestamp.proto\"\xe2\x05\n\x0b\x42ookControl\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12\x33\n\x04pkey\x18\x02 \x01(\x0b\x32%.spiderrock.protobuf.BookControl.PKey\x12\x34\n\x0b\x62ook_status\x18\x64 \x01(\x0e\x32\x1f.spiderrock.protobuf.BookStatus\x12\x1c\n\x14\x62ook_risk_multiplier\x18g \x01(\x02\x12\x17\n\x0fmax_acc_haircut\x18j \x01(\x02\x12\x13\n\x0bmin_acc_rho\x18m \x01(\x02\x12\x13\n\x0bmax_acc_rho\x18p \x01(\x02\x12\x12\n\nmin_dDelta\x18s \x01(\x05\x12\x12\n\nmax_dDelta\x18v \x01(\x05\x12\x1b\n\x13max_acc_abs_wt_vega\x18y \x01(\x02\x12\x17\n\x0fmin_acc_wt_vega\x18| \x01(\x02\x12\x17\n\x0fmax_acc_wt_vega\x18\x7f \x01(\x02\x12\x18\n\x0fmin_ind_wt_vega\x18\x82\x01 \x01(\x02\x12\x18\n\x0fmax_ind_wt_vega\x18\x85\x01 \x01(\x02\x12\x18\n\x0fmin_sub_wt_vega\x18\x88\x01 \x01(\x02\x12\x18\n\x0fmax_sub_wt_vega\x18\x8b\x01 \x01(\x02\x12\x18\n\x0fmin_grp_wt_vega\x18\x8e\x01 \x01(\x02\x12\x18\n\x0fmax_grp_wt_vega\x18\x91\x01 \x01(\x02\x12\x12\n\tuser_text\x18\x94\x01 \x01(\t\x12\x14\n\x0bmodified_by\x18\x97\x01 \x01(\t\x12\x39\n\x0bmodified_in\x18\x9a\x01 \x01(\x0e\x32#.spiderrock.protobuf.SysEnvironment\x12.\n\ttimestamp\x18\x9d\x01 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x1a*\n\x04PKey\x12\r\n\x05\x61\x63\x63nt\x18\n \x01(\t\x12\x13\n\x0b\x63lient_firm\x18\x0b \x01(\tb\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'ClientControl.BookControl_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_BOOKCONTROL']._serialized_start=115
  _globals['_BOOKCONTROL']._serialized_end=853
  _globals['_BOOKCONTROL_PKEY']._serialized_start=811
  _globals['_BOOKCONTROL_PKEY']._serialized_end=853
# @@protoc_insertion_point(module_scope)
