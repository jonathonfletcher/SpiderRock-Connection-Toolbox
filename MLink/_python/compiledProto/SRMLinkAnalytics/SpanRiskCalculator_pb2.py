# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: SRMLinkAnalytics/SpanRiskCalculator.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2
from google.protobuf import timestamp_pb2 as google_dot_protobuf_dot_timestamp__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n)SRMLinkAnalytics/SpanRiskCalculator.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\x1a\x1fgoogle/protobuf/timestamp.proto\"\xe0\x0e\n\x12SpanRiskCalculator\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12:\n\x04pkey\x18\x02 \x01(\x0b\x32,.spiderrock.protobuf.SpanRiskCalculator.PKey\x12\x0b\n\x03vol\x18\x64 \x01(\x01\x12.\n\x07vol_src\x18g \x01(\x0e\x32\x1d.spiderrock.protobuf.FieldSrc\x12\r\n\x05u_prc\x18j \x01(\x01\x12\x30\n\tu_prc_src\x18m \x01(\x0e\x32\x1d.spiderrock.protobuf.FieldSrc\x12\r\n\x05years\x18p \x01(\x01\x12\x30\n\tyears_src\x18s \x01(\x0e\x32\x1d.spiderrock.protobuf.FieldSrc\x12\x0c\n\x04sdiv\x18v \x01(\x01\x12/\n\x08sdiv_src\x18y \x01(\x0e\x32\x1d.spiderrock.protobuf.FieldSrc\x12\x0c\n\x04rate\x18| \x01(\x01\x12/\n\x08rate_src\x18\x7f \x01(\x0e\x32\x1d.spiderrock.protobuf.FieldSrc\x12\x33\n\x07\x65x_type\x18\x82\x01 \x01(\x0e\x32!.spiderrock.protobuf.ExerciseType\x12\x33\n\x0b\x65x_type_src\x18\x85\x01 \x01(\x0e\x32\x1d.spiderrock.protobuf.FieldSrc\x12\x13\n\neff_strike\x18\x88\x01 \x01(\x01\x12\x36\n\x0e\x65\x66\x66_strike_src\x18\x8b\x01 \x01(\x0e\x32\x1d.spiderrock.protobuf.FieldSrc\x12\x12\n\tsym_ratio\x18\x8e\x01 \x01(\x01\x12\x35\n\rsym_ratio_src\x18\x91\x01 \x01(\x0e\x32\x1d.spiderrock.protobuf.FieldSrc\x12\x13\n\ndiv_string\x18\x94\x01 \x01(\t\x12/\n\x07\x64iv_src\x18\x97\x01 \x01(\x0e\x32\x1d.spiderrock.protobuf.FieldSrc\x12\x37\n\nmodel_type\x18\x9a\x01 \x01(\x0e\x32\".spiderrock.protobuf.CalcModelType\x12\x36\n\x0emodel_type_src\x18\x9d\x01 \x01(\x0e\x32\x1d.spiderrock.protobuf.FieldSrc\x12;\n\x0e\x63\x61lc_precision\x18\xa0\x01 \x01(\x0e\x32\".spiderrock.protobuf.CalcPrecision\x12\x14\n\x0bpoint_value\x18\xa3\x01 \x01(\x01\x12\x36\n\x0epoint_currency\x18\xf8\x01 \x01(\x0e\x32\x1d.spiderrock.protobuf.Currency\x12\x37\n\x0fpoint_value_src\x18\xa6\x01 \x01(\x0e\x32\x1d.spiderrock.protobuf.FieldSrc\x12\x14\n\x0bprc_span_up\x18\xa9\x01 \x01(\x02\x12\x14\n\x0bprc_span_dn\x18\xac\x01 \x01(\x02\x12\x38\n\rprc_span_type\x18\xaf\x01 \x01(\x0e\x32 .spiderrock.protobuf.PrcSpanType\x12\x11\n\x08vol_span\x18\xb2\x01 \x01(\x02\x12\x38\n\rvol_span_type\x18\xb5\x01 \x01(\x0e\x32 .spiderrock.protobuf.VolSpanType\x12:\n\x0espan_calc_type\x18\xb8\x01 \x01(\x0e\x32!.spiderrock.protobuf.SpanCalcType\x12\x38\n\x13hedge_delta_neutral\x18\xbb\x01 \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x12\n\tadj_years\x18\xbe\x01 \x01(\x01\x12\x12\n\tmax_years\x18\xc1\x01 \x01(\x01\x12\x0f\n\x06span01\x18\xc4\x01 \x01(\x02\x12\x0f\n\x06span02\x18\xc7\x01 \x01(\x02\x12\x0f\n\x06span03\x18\xca\x01 \x01(\x02\x12\x0f\n\x06span04\x18\xcd\x01 \x01(\x02\x12\x0f\n\x06span05\x18\xd0\x01 \x01(\x02\x12\x0f\n\x06span06\x18\xd3\x01 \x01(\x02\x12\x0f\n\x06span07\x18\xd6\x01 \x01(\x02\x12\x0f\n\x06span08\x18\xd9\x01 \x01(\x02\x12\x0f\n\x06span09\x18\xdc\x01 \x01(\x02\x12\x0f\n\x06span10\x18\xdf\x01 \x01(\x02\x12\x0f\n\x06span11\x18\xe2\x01 \x01(\x02\x12\x0f\n\x06span12\x18\xe5\x01 \x01(\x02\x12\x0f\n\x06span13\x18\xe8\x01 \x01(\x02\x12\x0f\n\x06span14\x18\xeb\x01 \x01(\x02\x12\x0f\n\x06span15\x18\xee\x01 \x01(\x02\x12\x0f\n\x06span16\x18\xf1\x01 \x01(\x02\x12\x0e\n\x05\x65rror\x18\xf4\x01 \x01(\t\x12.\n\ttimestamp\x18\xf7\x01 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x1a~\n\x04PKey\x12/\n\x07sec_key\x18\n \x01(\x0b\x32\x1e.spiderrock.protobuf.OptionKey\x12\x32\n\x08sec_type\x18\x0b \x01(\x0e\x32 .spiderrock.protobuf.SpdrKeyType\x12\x11\n\tuser_name\x18\x0c \x01(\tb\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'SRMLinkAnalytics.SpanRiskCalculator_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_SPANRISKCALCULATOR']._serialized_start=125
  _globals['_SPANRISKCALCULATOR']._serialized_end=2013
  _globals['_SPANRISKCALCULATOR_PKEY']._serialized_start=1887
  _globals['_SPANRISKCALCULATOR_PKEY']._serialized_end=2013
# @@protoc_insertion_point(module_scope)
