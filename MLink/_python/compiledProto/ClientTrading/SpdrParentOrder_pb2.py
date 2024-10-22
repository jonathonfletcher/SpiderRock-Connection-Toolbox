# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: ClientTrading/SpdrParentOrder.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2
from google.protobuf import timestamp_pb2 as google_dot_protobuf_dot_timestamp__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n#ClientTrading/SpdrParentOrder.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\x1a\x1fgoogle/protobuf/timestamp.proto\"\xa7O\n\x0fSpdrParentOrder\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12\x37\n\x04pkey\x18\x02 \x01(\x0b\x32).spiderrock.protobuf.SpdrParentOrder.PKey\x12<\n\x0fsys_environment\x18\x64 \x01(\x0e\x32#.spiderrock.protobuf.SysEnvironment\x12\x32\n\nrun_status\x18g \x01(\x0e\x32\x1e.spiderrock.protobuf.RunStatus\x12=\n\x10spdr_action_type\x18j \x01(\x0e\x32#.spiderrock.protobuf.SpdrActionType\x12\x39\n\x0cparent_shape\x18m \x01(\x0e\x32#.spiderrock.protobuf.SpdrOrderShape\x12\x19\n\x11\x63lient_seq_num_in\x18p \x01(\x05\x12\x14\n\x0c\x61lt_order_id\x18s \x01(\t\x12\x19\n\x11\x61lt_prev_order_id\x18v \x01(\t\x12\x19\n\x11\x61lt_auto_hedge_id\x18| \x01(\t\x12\x11\n\talt_accnt\x18\x7f \x01(\t\x12\x16\n\ralt_user_name\x18\x82\x01 \x01(\t\x12\x19\n\x10src_routing_code\x18\x85\x01 \x01(\t\x12\x13\n\npackage_id\x18\x88\x01 \x01(\x03\x12\x30\n\x07sec_key\x18\x8b\x01 \x01(\x0b\x32\x1e.spiderrock.protobuf.OptionKey\x12\x33\n\x08sec_type\x18\x8e\x01 \x01(\x0e\x32 .spiderrock.protobuf.SpdrKeyType\x12\x16\n\rsecurity_desc\x18\x91\x01 \x01(\t\x12\x0e\n\x05\x61\x63\x63nt\x18\x94\x01 \x01(\t\x12\x14\n\x0b\x63lient_firm\x18\x97\x01 \x01(\t\x12\x35\n\x0bspdr_source\x18\x9a\x01 \x01(\x0e\x32\x1f.spiderrock.protobuf.SpdrSource\x12\x16\n\rgrouping_code\x18\x9d\x01 \x01(\x03\x12\x17\n\x0e\x65xec_brkr_code\x18\x8f\x08 \x01(\t\x12\x17\n\x0e\x65xtern_ex_dest\x18\x90\x08 \x01(\t\x12\x16\n\rextern_params\x18\xa6\x01 \x01(\t\x12\x11\n\x08strategy\x18\xa9\x01 \x01(\t\x12\x12\n\tuser_name\x18\xac\x01 \x01(\t\x12\x35\n\x0buser_source\x18\x87\x08 \x01(\x0e\x32\x1f.spiderrock.protobuf.SpdrSource\x12/\n\norder_dttm\x18\xb2\x01 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12\x31\n\norder_side\x18\xb5\x01 \x01(\x0e\x32\x1c.spiderrock.protobuf.BuySell\x12\x13\n\norder_size\x18\xb8\x01 \x01(\x05\x12\x1a\n\x11order_active_size\x18\xbb\x01 \x01(\x05\x12\x1e\n\x15\x63ur_cum_fill_quantity\x18\xbe\x01 \x01(\x05\x12:\n\x15\x61\x64\x64_cum_fill_quantity\x18\xc1\x01 \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x1a\n\x11max_exposure_size\x18\xc4\x01 \x01(\x05\x12\x1b\n\x12num_make_exchanges\x18\xc7\x01 \x01(\x05\x12=\n\x0bpublic_size\x18\xca\x01 \x01(\x0e\x32\'.spiderrock.protobuf.PublicSizeHandling\x12\x39\n\x14\x63\x61n_overlap_cxl_repl\x18\xcd\x01 \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x39\n\rprogress_rule\x18\xd0\x01 \x01(\x0e\x32!.spiderrock.protobuf.ProgressRule\x12?\n\x10\x62lock_visibility\x18\xd3\x01 \x01(\x0e\x32$.spiderrock.protobuf.BlockVisibility\x12\x1b\n\x12progress_slice_cnt\x18\xd6\x01 \x01(\x05\x12\x1d\n\x14progress_expose_time\x18\xd9\x01 \x01(\x05\x12\x1b\n\x12vwap_participation\x18\xdc\x01 \x01(\x02\x12\x1d\n\x14min_mkt_on_close_pct\x18\xdf\x01 \x01(\x05\x12\x37\n\x0ctrigger_type\x18\xe2\x01 \x01(\x0e\x32 .spiderrock.protobuf.TriggerType\x12\x16\n\rtrigger_level\x18\xe5\x01 \x01(\x02\x12\x41\n\x11\x61uction_responder\x18\xe8\x01 \x01(\x0e\x32%.spiderrock.protobuf.AuctionResponder\x12\x1a\n\x11max_make_exch_fee\x18\xeb\x01 \x01(\x02\x12\x1a\n\x11max_take_exch_fee\x18\xee\x01 \x01(\x02\x12;\n\x11inc_take_exch_fee\x18\xf1\x01 \x01(\x0e\x32\x1f.spiderrock.protobuf.IncExchFee\x12;\n\x11inc_make_exch_fee\x18\xf4\x01 \x01(\x0e\x32\x1f.spiderrock.protobuf.IncExchFee\x12:\n\x0emake_exch_rule\x18\xf7\x01 \x01(\x0e\x32!.spiderrock.protobuf.MakeExchRule\x12\x35\n\x0e\x63xl_uPrc_range\x18\xfa\x01 \x01(\x0e\x32\x1c.spiderrock.protobuf.UPrcCxl\x12\x11\n\x08min_uBid\x18\xfd\x01 \x01(\x02\x12\x11\n\x08max_uAsk\x18\x80\x02 \x01(\x02\x12\x36\n\x0cmin_max_type\x18\x83\x02 \x01(\x0e\x32\x1f.spiderrock.protobuf.MinMaxType\x12\x16\n\rmin_option_px\x18\x86\x02 \x01(\x02\x12\x19\n\x10max_child_orders\x18\x89\x02 \x01(\x05\x12\x12\n\texch_mask\x18\x8c\x02 \x01(\r\x12<\n\x0fspdr_stage_type\x18\x8f\x02 \x01(\x0e\x32\".spiderrock.protobuf.SpdrStageType\x12;\n\x0emarket_session\x18\x88\x08 \x01(\x0e\x32\".spiderrock.protobuf.MarketSession\x12/\n\nstart_dttm\x18\x95\x02 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12\x17\n\x0eorder_duration\x18\x98\x02 \x01(\x05\x12\x18\n\x0f\x61\x63tive_duration\x18\x89\x08 \x01(\x05\x12\x33\n\x0egood_till_dttm\x18\x9b\x02 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12\x33\n\nstart_type\x18\x9e\x02 \x01(\x0e\x32\x1e.spiderrock.protobuf.StartType\x12\x19\n\x10trigger_group_id\x18\xa1\x02 \x01(\x03\x12\x1a\n\x11trigger_timestamp\x18\xa4\x02 \x01(\x03\x12H\n\x15parent_order_handling\x18\xaa\x02 \x01(\x0e\x32(.spiderrock.protobuf.ParentOrderHandling\x12L\n\x17parent_balance_handling\x18\xad\x02 \x01(\x0e\x32*.spiderrock.protobuf.ParentBalanceHandling\x12=\n\x10order_limit_type\x18\xb0\x02 \x01(\x0e\x32\".spiderrock.protobuf.SpdrLimitType\x12>\n\x10take_limit_class\x18\xb3\x02 \x01(\x0e\x32#.spiderrock.protobuf.SpdrLimitClass\x12>\n\x10make_limit_class\x18\xb6\x02 \x01(\x0e\x32#.spiderrock.protobuf.SpdrLimitClass\x12\x38\n\x0ftake_reach_rule\x18\xb9\x02 \x01(\x0e\x32\x1e.spiderrock.protobuf.ReachRule\x12\x18\n\x0forder_prc_limit\x18\xbc\x02 \x01(\x01\x12\x17\n\x0eorder_ref_uPrc\x18\xbf\x02 \x01(\x01\x12\x18\n\x0forder_ref_delta\x18\xc2\x02 \x01(\x02\x12\x18\n\x0forder_ref_gamma\x18\xc5\x02 \x01(\x02\x12\x18\n\x0forder_vol_limit\x18\xc8\x02 \x01(\x02\x12\x16\n\rrate_override\x18\xcb\x02 \x01(\x02\x12\x16\n\rsdiv_override\x18\xce\x02 \x01(\x02\x12\x16\n\rddiv_override\x18\xd1\x02 \x01(\t\x12\x39\n\roverride_code\x18\xd4\x02 \x01(\x0e\x32!.spiderrock.protobuf.OverrideCode\x12\x19\n\x10order_prc_offset\x18\xd7\x02 \x01(\x01\x12\x35\n\x0bstate_model\x18\xda\x02 \x01(\x0e\x32\x1f.spiderrock.protobuf.StateModel\x12\x37\n\ru_state_model\x18\xdd\x02 \x01(\x0e\x32\x1f.spiderrock.protobuf.StateModel\x12\x38\n\x0ftake_alpha_type\x18\xe0\x02 \x01(\x0e\x32\x1e.spiderrock.protobuf.AlphaType\x12\x38\n\x0fmake_alpha_type\x18\xe3\x02 \x01(\x0e\x32\x1e.spiderrock.protobuf.AlphaType\x12\x1a\n\x11take_alpha_factor\x18\xe6\x02 \x01(\x02\x12\x1a\n\x11make_alpha_factor\x18\xe9\x02 \x01(\x02\x12\x19\n\x10take_probability\x18\xec\x02 \x01(\x02\x12\x19\n\x10make_probability\x18\xef\x02 \x01(\x02\x12\x1d\n\x14take_surf_prc_offset\x18\xf2\x02 \x01(\x01\x12\x1d\n\x14take_surf_vol_offset\x18\xf5\x02 \x01(\x02\x12\x1f\n\x16take_surf_width_offset\x18\xf8\x02 \x01(\x02\x12\x1d\n\x14make_surf_prc_offset\x18\xfb\x02 \x01(\x01\x12\x1d\n\x14make_surf_vol_offset\x18\xfe\x02 \x01(\x02\x12\x1f\n\x16make_surf_width_offset\x18\x81\x03 \x01(\x02\x12\x1d\n\x14order_ref_event_mult\x18\x84\x03 \x01(\x02\x12\x39\n\x14order_ref_event_dttm\x18\x87\x03 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12\x33\n\nauto_hedge\x18\x8a\x03 \x01(\x0e\x32\x1e.spiderrock.protobuf.AutoHedge\x12\x39\n\x10hedge_instrument\x18\x8d\x03 \x01(\x0e\x32\x1e.spiderrock.protobuf.HedgeInst\x12\x36\n\rhedge_sec_key\x18\x90\x03 \x01(\x0b\x32\x1e.spiderrock.protobuf.ExpiryKey\x12\x19\n\x10hedge_beta_ratio\x18\x93\x03 \x01(\x02\x12\x35\n\x0bhedge_scope\x18\x96\x03 \x01(\x0e\x32\x1f.spiderrock.protobuf.HedgeScope\x12:\n\rhedge_session\x18\x8a\x08 \x01(\x0e\x32\".spiderrock.protobuf.MarketSession\x12\x1d\n\x14\x65xtern_hedge_ex_dest\x18\x91\x08 \x01(\t\x12\x1c\n\x13\x65xtern_hedge_params\x18\x9f\x03 \x01(\t\x12\x31\n\tfirm_type\x18\xa2\x03 \x01(\x0e\x32\x1d.spiderrock.protobuf.FirmType\x12;\n\x0eorder_capacity\x18\xa5\x03 \x01(\x0e\x32\".spiderrock.protobuf.OrderCapacity\x12\x39\n\rposition_type\x18\xa8\x03 \x01(\x0e\x32!.spiderrock.protobuf.PositionType\x12\x37\n\nssale_flag\x18\xab\x03 \x01(\x0e\x32\".spiderrock.protobuf.ShortSaleFlag\x12\x17\n\x0eno_cross_group\x18\xae\x03 \x01(\t\x12\x17\n\x0e\x65xch_trader_id\x18\xb1\x03 \x01(\t\x12\x18\n\x0flarge_trader_id\x18\xb4\x03 \x01(\t\x12\x19\n\x10trading_location\x18\xb7\x03 \x01(\t\x12\x30\n\tlead_side\x18\xe4\x03 \x01(\x0e\x32\x1c.spiderrock.protobuf.BuySell\x12 \n\x17max_completion_slippage\x18\xe7\x03 \x01(\x01\x12\x1a\n\x11order_ref_premium\x18\xea\x03 \x01(\x02\x12\x16\n\rnotice_number\x18\x8e\x08 \x01(\x03\x12\x11\n\x08theo_vol\x18\xf0\x03 \x01(\x02\x12\x17\n\x0e\x63l_arrive_mark\x18\xf3\x03 \x01(\x02\x12\x16\n\rrisk_group_id\x18\xf6\x03 \x01(\x03\x12<\n\x17req_aux_risk_group_ctrl\x18\x8c\x08 \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12=\n\x10ref_rMetric1_src\x18\xba\x03 \x01(\x0e\x32\".spiderrock.protobuf.RMetricSource\x12=\n\x10ref_rMetric2_src\x18\xbd\x03 \x01(\x0e\x32\".spiderrock.protobuf.RMetricSource\x12=\n\x10ref_rMetric3_src\x18\xc0\x03 \x01(\x0e\x32\".spiderrock.protobuf.RMetricSource\x12=\n\x10ref_rMetric4_src\x18\xc3\x03 \x01(\x0e\x32\".spiderrock.protobuf.RMetricSource\x12=\n\x10ref_rMetric5_src\x18\xc6\x03 \x01(\x0e\x32\".spiderrock.protobuf.RMetricSource\x12=\n\x10ref_rMetric6_src\x18\xc9\x03 \x01(\x0e\x32\".spiderrock.protobuf.RMetricSource\x12=\n\x10ref_rMetric7_src\x18\xcc\x03 \x01(\x0e\x32\".spiderrock.protobuf.RMetricSource\x12\x1b\n\x12order_ref_rMetric1\x18\xcf\x03 \x01(\x02\x12\x1b\n\x12order_ref_rMetric2\x18\xd2\x03 \x01(\x02\x12\x1b\n\x12order_ref_rMetric3\x18\xd5\x03 \x01(\x02\x12\x1b\n\x12order_ref_rMetric4\x18\xd8\x03 \x01(\x02\x12\x1b\n\x12order_ref_rMetric5\x18\xdb\x03 \x01(\x02\x12\x1b\n\x12order_ref_rMetric6\x18\xde\x03 \x01(\x02\x12\x1b\n\x12order_ref_rMetric7\x18\xe1\x03 \x01(\x02\x12\x1f\n\x16\x65xp_day_wt_vega_offset\x18\x91\x04 \x01(\x02\x12\x1f\n\x16max_exp_day_wt_vega_ln\x18\x8b\x04 \x01(\x02\x12\x1f\n\x16max_exp_day_wt_vega_sh\x18\x8e\x04 \x01(\x02\x12 \n\x17max_exp_day_rMetric6_ln\x18\xaf\x04 \x01(\x02\x12 \n\x17max_exp_day_rMetric6_sh\x18\xb2\x04 \x01(\x02\x12\x1e\n\x15sym_day_dDelta_offset\x18\xac\x04 \x01(\x02\x12\x1e\n\x15max_sym_day_dDelta_ln\x18\xa6\x04 \x01(\x02\x12\x1e\n\x15max_sym_day_dDelta_sh\x18\xa9\x04 \x01(\x02\x12\x1c\n\x13sym_day_vega_offset\x18\x9a\x04 \x01(\x02\x12\x1c\n\x13max_sym_day_vega_ln\x18\x94\x04 \x01(\x02\x12\x1c\n\x13max_sym_day_vega_sh\x18\x97\x04 \x01(\x02\x12\x1f\n\x16sym_day_wt_vega_offset\x18\xa3\x04 \x01(\x02\x12\x1f\n\x16max_sym_day_wt_vega_ln\x18\x9d\x04 \x01(\x02\x12\x1f\n\x16max_sym_day_wt_vega_sh\x18\xa0\x04 \x01(\x02\x12 \n\x17max_sym_day_rMetric7_ln\x18\xb8\x04 \x01(\x02\x12 \n\x17max_sym_day_rMetric7_sh\x18\xbb\x04 \x01(\x02\x12\x1e\n\x15max_grp_day_dDelta_ln\x18\xc1\x04 \x01(\x02\x12\x1e\n\x15max_grp_day_dDelta_sh\x18\xc4\x04 \x01(\x02\x12\x1c\n\x13max_grp_day_vega_ln\x18\xca\x04 \x01(\x02\x12\x1c\n\x13max_grp_day_vega_sh\x18\xcd\x04 \x01(\x02\x12\x1d\n\x14max_grp_day_vega_abs\x18\xd0\x04 \x01(\x02\x12\x1b\n\x12grp_day_vega_ratio\x18\xd3\x04 \x01(\x02\x12!\n\x18max_grp_day_contracts_ln\x18\x86\x05 \x01(\x05\x12!\n\x18max_grp_day_contracts_sh\x18\x89\x05 \x01(\x05\x12\"\n\x19max_grp_day_contracts_abs\x18\x8c\x05 \x01(\x05\x12 \n\x17max_grp_day_rMetric1_ln\x18\xe2\x04 \x01(\x02\x12 \n\x17max_grp_day_rMetric1_sh\x18\xe5\x04 \x01(\x02\x12!\n\x18max_grp_day_rMetric1_abs\x18\xe8\x04 \x01(\x02\x12\x1f\n\x16grp_day_rMetric1_ratio\x18\xeb\x04 \x01(\x02\x12 \n\x17max_grp_day_rMetric2_ln\x18\xee\x04 \x01(\x02\x12 \n\x17max_grp_day_rMetric2_sh\x18\xf1\x04 \x01(\x02\x12 \n\x17max_grp_day_rMetric3_ln\x18\xf4\x04 \x01(\x02\x12 \n\x17max_grp_day_rMetric3_sh\x18\xf7\x04 \x01(\x02\x12 \n\x17max_grp_day_rMetric4_ln\x18\xfa\x04 \x01(\x02\x12 \n\x17max_grp_day_rMetric4_sh\x18\xfd\x04 \x01(\x02\x12 \n\x17max_grp_day_rMetric5_ln\x18\x80\x05 \x01(\x02\x12 \n\x17max_grp_day_rMetric5_sh\x18\x83\x05 \x01(\x02\x12\x1e\n\x15sym_ema_cxl_dDelta_ln\x18\x8f\x05 \x01(\x02\x12\x1e\n\x15sym_ema_cxl_dDelta_sh\x18\x92\x05 \x01(\x02\x12\x1f\n\x16sym_ema_cxl_wt_vega_ln\x18\x95\x05 \x01(\x02\x12\x1f\n\x16sym_ema_cxl_wt_vega_sh\x18\x98\x05 \x01(\x02\x12\x33\n\x0elast_fill_dttm\x18\x9b\x05 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12\x13\n\nuser_data1\x18\x9e\x05 \x01(\t\x12\x13\n\nuser_data2\x18\xa1\x05 \x01(\t\x12\x13\n\nchild_data\x18\xa4\x05 \x01(\t\x12\x16\n\rsrc_timestamp\x18\xa7\x05 \x01(\x03\x12\x16\n\rsgw_timestamp\x18\xaa\x05 \x01(\x03\x12.\n\ttimestamp\x18\xad\x05 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12\x41\n\x11include_sRNetwork\x18\x8d\x08 \x01(\x0e\x32%.spiderrock.protobuf.InclExclDisclose\x12Z\n\x16\x64irected_counter_party\x18\xb6\x05 \x03(\x0b\x32\x39.spiderrock.protobuf.SpdrParentOrder.DirectedCounterParty\x12\x43\n\norder_legs\x18\xef\x05 \x03(\x0b\x32..spiderrock.protobuf.SpdrParentOrder.OrderLegs\x1a\x1d\n\x04PKey\x12\x15\n\rparent_number\x18\n \x01(\x03\x1ag\n\x14\x44irectedCounterParty\x12\x14\n\x0b\x63lient_firm\x18\xb9\x05 \x01(\t\x12\x39\n\tincl_excl\x18\xbc\x05 \x01(\x0e\x32%.spiderrock.protobuf.InclExclDisclose\x1a\xfb\x14\n\tOrderLegs\x12/\n\x06ticker\x18\xf2\x05 \x01(\x0b\x32\x1e.spiderrock.protobuf.TickerKey\x12\x31\n\nstock_side\x18\xf5\x05 \x01(\x0e\x32\x1c.spiderrock.protobuf.BuySell\x12\x15\n\x0cstock_shares\x18\xf8\x05 \x01(\x05\x12\x15\n\x0cstock_leg_id\x18\xfb\x05 \x01(\x03\x12\x17\n\x0e\x61lt_stk_leg_id\x18\xfe\x05 \x01(\t\x12\x37\n\nssale_flag\x18\x81\x06 \x01(\x0e\x32\".spiderrock.protobuf.ShortSaleFlag\x12\x11\n\x08ref_uPrc\x18\x87\x06 \x01(\x02\x12\x11\n\x08num_legs\x18\x8a\x06 \x01(\x05\x12\x31\n\x08sec_key1\x18\x8d\x06 \x01(\x0b\x32\x1e.spiderrock.protobuf.OptionKey\x12\x34\n\tsec_type1\x18\x90\x06 \x01(\x0e\x32 .spiderrock.protobuf.SpdrKeyType\x12\x0e\n\x05mult1\x18\x93\x06 \x01(\r\x12,\n\x05side1\x18\x96\x06 \x01(\x0e\x32\x1c.spiderrock.protobuf.BuySell\x12\x10\n\x07leg_id1\x18\x99\x06 \x01(\x03\x12\x14\n\x0b\x61lt_leg_id1\x18\x9c\x06 \x01(\t\x12\x35\n\tpos_type1\x18\x9f\x06 \x01(\x0e\x32!.spiderrock.protobuf.PositionType\x12\x38\n\x0bssale_flag1\x18\xa5\x06 \x01(\x0e\x32\".spiderrock.protobuf.ShortSaleFlag\x12\x0e\n\x05vega1\x18\xab\x06 \x01(\x02\x12\x12\n\tref_uPrc1\x18\xae\x06 \x01(\x01\x12\x13\n\nref_delta1\x18\xb1\x06 \x01(\x02\x12\x16\n\rref_earn_cnt1\x18\xb4\x06 \x01(\x05\x12\x31\n\x08sec_key2\x18\xb7\x06 \x01(\x0b\x32\x1e.spiderrock.protobuf.OptionKey\x12\x34\n\tsec_type2\x18\xba\x06 \x01(\x0e\x32 .spiderrock.protobuf.SpdrKeyType\x12\x0e\n\x05mult2\x18\xbd\x06 \x01(\r\x12,\n\x05side2\x18\xc0\x06 \x01(\x0e\x32\x1c.spiderrock.protobuf.BuySell\x12\x10\n\x07leg_id2\x18\xc3\x06 \x01(\x03\x12\x14\n\x0b\x61lt_leg_id2\x18\xc6\x06 \x01(\t\x12\x35\n\tpos_type2\x18\xc9\x06 \x01(\x0e\x32!.spiderrock.protobuf.PositionType\x12\x38\n\x0bssale_flag2\x18\xcf\x06 \x01(\x0e\x32\".spiderrock.protobuf.ShortSaleFlag\x12\x0e\n\x05vega2\x18\xd5\x06 \x01(\x02\x12\x12\n\tref_uPrc2\x18\xd8\x06 \x01(\x01\x12\x13\n\nref_delta2\x18\xdb\x06 \x01(\x02\x12\x16\n\rref_earn_cnt2\x18\xde\x06 \x01(\x05\x12\x31\n\x08sec_key3\x18\xe1\x06 \x01(\x0b\x32\x1e.spiderrock.protobuf.OptionKey\x12\x34\n\tsec_type3\x18\xe4\x06 \x01(\x0e\x32 .spiderrock.protobuf.SpdrKeyType\x12\x0e\n\x05mult3\x18\xe7\x06 \x01(\r\x12,\n\x05side3\x18\xea\x06 \x01(\x0e\x32\x1c.spiderrock.protobuf.BuySell\x12\x10\n\x07leg_id3\x18\xed\x06 \x01(\x03\x12\x14\n\x0b\x61lt_leg_id3\x18\xf0\x06 \x01(\t\x12\x35\n\tpos_type3\x18\xf3\x06 \x01(\x0e\x32!.spiderrock.protobuf.PositionType\x12\x38\n\x0bssale_flag3\x18\xf9\x06 \x01(\x0e\x32\".spiderrock.protobuf.ShortSaleFlag\x12\x0e\n\x05vega3\x18\xff\x06 \x01(\x02\x12\x12\n\tref_uPrc3\x18\x82\x07 \x01(\x01\x12\x13\n\nref_delta3\x18\x85\x07 \x01(\x02\x12\x16\n\rref_earn_cnt3\x18\x88\x07 \x01(\x05\x12\x31\n\x08sec_key4\x18\x8b\x07 \x01(\x0b\x32\x1e.spiderrock.protobuf.OptionKey\x12\x34\n\tsec_type4\x18\x8e\x07 \x01(\x0e\x32 .spiderrock.protobuf.SpdrKeyType\x12\x0e\n\x05mult4\x18\x91\x07 \x01(\r\x12,\n\x05side4\x18\x94\x07 \x01(\x0e\x32\x1c.spiderrock.protobuf.BuySell\x12\x10\n\x07leg_id4\x18\x97\x07 \x01(\x03\x12\x14\n\x0b\x61lt_leg_id4\x18\x9a\x07 \x01(\t\x12\x35\n\tpos_type4\x18\x9d\x07 \x01(\x0e\x32!.spiderrock.protobuf.PositionType\x12\x38\n\x0bssale_flag4\x18\xa3\x07 \x01(\x0e\x32\".spiderrock.protobuf.ShortSaleFlag\x12\x0e\n\x05vega4\x18\xa9\x07 \x01(\x02\x12\x12\n\tref_uPrc4\x18\xac\x07 \x01(\x01\x12\x13\n\nref_delta4\x18\xaf\x07 \x01(\x02\x12\x16\n\rref_earn_cnt4\x18\xb2\x07 \x01(\x05\x12\x31\n\x08sec_key5\x18\xb5\x07 \x01(\x0b\x32\x1e.spiderrock.protobuf.OptionKey\x12\x34\n\tsec_type5\x18\xb8\x07 \x01(\x0e\x32 .spiderrock.protobuf.SpdrKeyType\x12\x0e\n\x05mult5\x18\xbb\x07 \x01(\r\x12,\n\x05side5\x18\xbe\x07 \x01(\x0e\x32\x1c.spiderrock.protobuf.BuySell\x12\x10\n\x07leg_id5\x18\xc1\x07 \x01(\x03\x12\x14\n\x0b\x61lt_leg_id5\x18\xc4\x07 \x01(\t\x12\x35\n\tpos_type5\x18\xc7\x07 \x01(\x0e\x32!.spiderrock.protobuf.PositionType\x12\x38\n\x0bssale_flag5\x18\xcd\x07 \x01(\x0e\x32\".spiderrock.protobuf.ShortSaleFlag\x12\x0e\n\x05vega5\x18\xd3\x07 \x01(\x02\x12\x12\n\tref_uPrc5\x18\xd6\x07 \x01(\x01\x12\x13\n\nref_delta5\x18\xd9\x07 \x01(\x02\x12\x16\n\rref_earn_cnt5\x18\xdc\x07 \x01(\x05\x12\x31\n\x08sec_key6\x18\xdf\x07 \x01(\x0b\x32\x1e.spiderrock.protobuf.OptionKey\x12\x34\n\tsec_type6\x18\xe2\x07 \x01(\x0e\x32 .spiderrock.protobuf.SpdrKeyType\x12\x0e\n\x05mult6\x18\xe5\x07 \x01(\r\x12,\n\x05side6\x18\xe8\x07 \x01(\x0e\x32\x1c.spiderrock.protobuf.BuySell\x12\x10\n\x07leg_id6\x18\xeb\x07 \x01(\x03\x12\x14\n\x0b\x61lt_leg_id6\x18\xee\x07 \x01(\t\x12\x35\n\tpos_type6\x18\xf1\x07 \x01(\x0e\x32!.spiderrock.protobuf.PositionType\x12\x38\n\x0bssale_flag6\x18\xf7\x07 \x01(\x0e\x32\".spiderrock.protobuf.ShortSaleFlag\x12\x0e\n\x05vega6\x18\xfd\x07 \x01(\x02\x12\x12\n\tref_uPrc6\x18\x80\x08 \x01(\x01\x12\x13\n\nref_delta6\x18\x83\x08 \x01(\x02\x12\x16\n\rref_earn_cnt6\x18\x86\x08 \x01(\x05\x62\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'ClientTrading.SpdrParentOrder_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_SPDRPARENTORDER']._serialized_start=119
  _globals['_SPDRPARENTORDER']._serialized_end=10270
  _globals['_SPDRPARENTORDER_PKEY']._serialized_start=7450
  _globals['_SPDRPARENTORDER_PKEY']._serialized_end=7479
  _globals['_SPDRPARENTORDER_DIRECTEDCOUNTERPARTY']._serialized_start=7481
  _globals['_SPDRPARENTORDER_DIRECTEDCOUNTERPARTY']._serialized_end=7584
  _globals['_SPDRPARENTORDER_ORDERLEGS']._serialized_start=7587
  _globals['_SPDRPARENTORDER_ORDERLEGS']._serialized_end=10270
# @@protoc_insertion_point(module_scope)
