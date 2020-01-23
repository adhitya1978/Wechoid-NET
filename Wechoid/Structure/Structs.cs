using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;


namespace Wechoid.Structure
{
    public struct CHALLENGE
    {
        public uint ulReserved;
        public uint ulChallengedSecret;
        public uint ulChallengeSize;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 30)]
        public string ChallengeData;
    }
    public struct CHALLENGERESPONSE
    {
        public uint ulResponseSize;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string ResponseData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct LS_LIBVERSION
    {
        public uint ulInfoCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
        public string szVersion;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
        public string szProtocol;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
        public string szPlatform;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
        public string szLocale;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
        public string szUnused2;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VLSClientInfo
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x40)]
        public string user_name;
        public uint host_id;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x40)]
        public string group;
        public int start_time;
        public int hold_time;
        public int end_time;
        public int key_id;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x40)]
        public string host_name;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x40)]
        public string x_display_name;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x40)]
        public string shared_id_name;
        public int num_units;
        public int q_wait_time;
        public int is_holding;
        public int is_sharing;
        public int is_commuted;
        public int structSz;
        public uint team_capacity;
        public uint total_resv_team_capacity;
        public uint reserved_team_capacity_in_use;
        public uint unreserved_team_capacity_in_use;
        public uint user_capacity_from_reserved;
        public uint user_capacity_from_unreserved;
        public int total_team_tokens_resv;
        public int reserved_team_tokens_in_use;
        public int unreserved_team_tokens_in_use;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct VLScommuterInfo
    {
        public int commuter_code_version;
        public int codegen_version;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x40)]
        public string feature_name;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
        public string feature_version;
        public int birth_day;
        public int birth_month;
        public int birth_year;
        public int death_day;
        public int death_month;
        public int death_year;
        public int num_of_licenses;
        public int locking_crit;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 200)]
        public string lock_info;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x7d1)]
        public string vendor_info;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x7d0)]
        public string issuing_server;
        public int key_life_time;
        public int protocol_type;
        public int status;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct VLScustomEx
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x40)]
        public string customEx;
        public int len;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VLSdiscoverInfo
    {
        public short protocol;
        public short isRedundant;
        public int num_clients;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x40)]
        public string ip_address;
        public int num_units_available;
        public int is_served;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        public string pool_name;
        public int reserved1;
        public int reserved2;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VLSerrorLine
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x200)]
        public string errorMsg;
        private int lineNumber;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct VLSFeatureInfo
    {
        public int structSz;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x40)]
        public string feature_name;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x40)]
        public string version;
        public int lic_type;
        public int trial_days_count;
        public int birth_day;
        public int death_day;
        public int num_licenses;
        public int total_resv;
        public int lic_from_resv;
        public int qlic_from_resv;
        public int lic_from_free_pool;
        public int qlic_from_free_pool;
        public int is_node_locked;
        public int concurrency;
        public int sharing_crit;
        public int locking_crit;
        public int holding_crit;
        public int num_subnets;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 150)]
        public string site_license_info;
        public int hold_time;
        public int meter_value;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x7d1)]
        public string vendor_info;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 200)]
        public string cl_lock_info;
        public int key_life_time;
        public int sharing_limit;
        public int soft_num_licenses;
        public int is_standalone;
        public int check_time_tamper;
        public int is_additive;
        public int isRedundant;
        public int majority_rule;
        public int num_servers;
        public int isCommuter;
        public int log_encrypt_level;
        public int elan_key_flag;
        public int conversion_time;
        public int avg_queue_time;
        public int queue_length;
        public int tot_lic_reqd;
        public int isELMEnabled;
        public int commuted_keys;
        public int commuter_keys_left;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 250)]
        public string server_locking_info;
        public int capacity_flag;
        public int capacity;
        public int total_resv_capacity;
        public int in_use_capacity_from_reserved;
        public int in_use_capacity_from_unreserved;
        public int commuter_max_checkout_days;
        public int grace_period_flag;
        public int grace_period_calendar_days;
        public int grace_period_elapsed_hours;
        public int overdraft_flag;
        public int overdraft_hours;
        public int overdraft_users;
        public int overdraft_users_in_use;
        public int local_request_lockcrit_flag;
        public int local_request_lockcrit_required;
        public int local_request_lockcrit_float;
        public int local_request_lockcrit_min_num;
        public int isGraceLicense;
        public int license_version;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x18c)]
        public string plain_vendor_info;
        public int trial_elapsed_hours;
        public int trial_execution_count;
        public int trial_calendar_period_left;
        public int trial_elapsed_period_left;
        public int trial_executions_left;
        public int trial_current_status;
        public int vm_detection;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct VLSlicenseInfo
    {
        public int structSz;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x41)]
        public string feature_name;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x41)]
        public string version;
        public int lic_type;
        public int trial_days_count;
        public int birth_day;
        public int death_day;
        public int num_licenses;
        public int is_node_locked;
        public int concurrency;
        public int sharing_crit;
        public int locking_crit;
        public int holding_crit;
        public int num_subnets;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x97)]
        public string site_license_info;
        public int hold_time;
        public int meter_value;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x7d1)]
        public string vendor_info;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0xc9)]
        public string cl_lock_info;
        public int key_life_time;
        public int sharing_limit;
        public int soft_num_licenses;
        public int is_standalone;
        public int check_time_tamper;
        public int is_additive;
        public int num_servers;
        public int isRedundant;
        public int majority_rule;
        public int log_encrypt_level;
        public int elan_key_flag;
        public int conversion_time;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0xfb)]
        public string server_locking_info;
        public int capacity_flag;
        public uint capacity;
        public int isCommuter;
        public int commuter_max_checkout_days;
        public int grace_period_flag;
        public int grace_period_calendar_days;
        public int grace_period_elapsed_hours;
        public int overdraft_flag;
        public int overdraft_hours;
        public int overdraft_users;
        public int local_request_lockcrit_flag;
        public int local_request_lockcrit_required;
        public int local_request_lockcrit_float;
        public int local_request_lockcrit_min_num;
        public int license_version;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x18c)]
        public string plain_vendor_info;
        public int trial_elapsed_hours;
        public int trial_execution_count;
        public int trial_calendar_period_left;
        public int trial_elapsed_period_left;
        public int trial_executions_left;
        public int trial_current_status;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x12)]
        public string license_hash;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x101)]
        public string license_storage;
        public int license_state;
        public int license_precedence;
        public int vm_detection;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VLSmachineID
    {
        public uint id_prom;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x40)]
        public string ip_addr;
        public uint disk_id;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x40)]
        public string host_name;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x40)]
        public string ethernet;
        public uint nw_ipx;
        public uint nw_serial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x40)]
        public string portserv_addr;
        public uint custom;
        public uint reserved;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x19)]
        public string cpu_id;
        public VLScustomEx customEx;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x40)]
        public string hard_disk_serial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x401)]
        public string cpu_info;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x25)]
        public string uuid;
        public uint unused2;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VLSqueuedClientInfo
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x40)]
        public string user_name;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x40)]
        public string host_name;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x40)]
        public string x_display_name;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x40)]
        public string shared_id_name;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x40)]
        public string group_name;
        public uint host_id;
        public int server_start_time;
        public int server_end_time;
        public uint qkey_id;
        public int num_units;
        public int num_resvd_default;
        public int num_resvd_native;
        public int wait_time;
        public int hold_time;
        public int priority_num;
        public int absPosition;
        public int grpPosition;
        public int availabilityTime;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VLSqueuePreference
    {
        public int wait_time;
        public int hold_time;
        public int priority_numl;
        public int absPosition;
        public int grpPosition;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VLSserverInfo
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string identifier;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x400)]
        public string inBuf;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x400)]
        public string outBuf;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct VLSservInfo
    {
        public int structSz;
        public int major_no;
        public int minor_no;
        public int revision_no;
        public int build_no;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x23)]
        public string locale;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
        public string vendor_info;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string platform;
        public int lock_mask;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string unused1;
        public int unused2;
        public VLStimeTamperInfo tmtmpr_info;
        public VLSmachineID machine_id;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VLStimeTamperInfo
    {
        public int structSz;
        public int lastTime;
        public int currTime;
        public int grace_period;
        public int percentViolationAllowed;
        public int numViolationForError;
        public int numViolationFound;
        public int percentViolationFound;
        public int clkSetBackTime;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct VLStrialUsageInfo
    {
        public int structSz;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x41)]
        public string feature_name;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x41)]
        public string version;
        public int cumulative_trial_days_count;
        public int cumulative_trial_elapsed_hours;
        public int cumulative_trial_execution_count;
        public int cumulative_trial_calendar_period_left;
        public int cumulative_trial_elapsed_period_left;
        public int cumulative_trial_executions_left;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct VLSVMInfo
    {
        public int structSz;
        public int isVirtualMachine;
    }

}
