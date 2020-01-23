using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using Wechoid.Structure;

namespace Wechoid.Const
{
   public class Const
    {
       static Const()
        {
            VLS_LOCK_NONET = 0x3fff;
            VLS_MACHINEID_STRING_SIZE = (Marshal.SizeOf(new VLSmachineID()) + 0x1c) + Marshal.SizeOf(new VLScustomEx());
            MAX_FINGER_PRINT = ((VLS_MACHINEID_STRING_SIZE + 14) * 2) + 4;
        }
          
       public const int BASE_LOCK_CODE_LENGTH = 0x10;
    public const int FAIL = 1;
    public const int FILE_VERSION_BUILD = 900;
    public const int FILE_VERSION_MAJOR = 8;
    public const int FILE_VERSION_MINOR = 4;
    public const int FILE_VERSION_POINT = 0;
    public const string FILE_VERSION_STRING = "8, 4, 0, 900\0";
    public const int HOOK_CLIENT_IDENTIFIER_SIZE = 100;
    public const int HOOK_LS_MAX_PATHLEN = 0x80;
    public const int HOSTID_ARRAY_SIZE = 4;
    public const int LIBINFOLEN = 0x20;
    public const string LS_ANY = "";
    public const uint LS_BAD_INDEX = 0xc800100b;
    public const uint LS_BADHANDLE = 0xc8001001;
    public const uint LS_BUFFER_TOO_SMALL = 0xc800100e;
    public const string LS_COPYRIGHT = "    Copyright (C) 2010 SafeNet, Inc.\n\n";
    public const uint LS_Default_Units = uint.MaxValue;
    public const uint LS_GRACE_EXPIRED = 0xc8001010;
    public const uint LS_GRACE_HOURS_EXHAUSTED = 0xc8001012;
    public const uint LS_GRACE_INVALID_STATE = 0xc8001011;
    public const uint LS_INSUFFICIENTUNITS = 0xc8001002;
    public const uint LS_INSUFFICIENTUNITS_ON_FOLLOWER = 0xc8001013;
    public const uint LS_LICENSE_EXPIRED = 0xc800100d;
    public const uint LS_LICENSESYSNOTAVAILABLE = 0xc8001003;
    public const uint LS_LICENSETERMINATED = 0xc8001004;
    public const string LS_MAJOR_VERSION = "8.4";
    public const uint LS_NO_MORE_UNITS = 0xc800100c;
    public const uint LS_NO_MSG_TEXT = 0xc8001009;
    public const uint LS_NO_NETWORK = 0xc8001008;
    public const uint LS_NO_SUCCESS = 0xc800100f;
    public const uint LS_NOAUTHORIZATIONAVAILABLE = 0xc8001005;
    public const uint LS_NOLICENSESAVAILABLE = 0xc8001006;
    public const uint LS_NORESOURCES = 0xc8001007;
    public const string LS_PROD_NAME = "Sentinel RMS Development Kit";
    public const string LS_PROD_NAME_SRV = "Sentinel RMS License Manager";
    public const int LS_REL_POST = 3;
    public const int LS_REL_PRE = 2;
    public const int LS_REQ_POST = 1;
    public const int LS_REQ_PRE = 0;
    public const uint LS_SUCCESS = 0;
    public const uint LS_UNKNOWN_STATUS = 0xc800100a;
    public const uint LS_USE_LAST = 0x800ffff;
    public const string LS_VERSION = "8.4.0.900";
    public const int LSERV_STATUS_DENY = 0x65;
    public const int LSERV_STATUS_SUCCESS = 0;
    public static int MAX_FINGER_PRINT;
    public const int MAX_LINE_NUM = 0x200;
    public const int NO_RET_ON_FIRST = 0;
    public const int PRODUCT_VERSION_BUILD = 900;
    public const int PRODUCT_VERSION_MAJOR = 8;
    public const int PRODUCT_VERSION_MINOR = 4;
    public const int PRODUCT_VERSION_POINT = 0;
    public const string PRODUCT_VERSION_STRING = "8, 4, 0, 900\0";
    public const uint PUBLIC_VENINFOLEN = 0x18b;
    public const int RET_ON_FIRST = 1;
    public const uint ULC_CODE_VERSION = 2;
    public const uint ULC_CODE_VERSION_1 = 1;
    public const uint ULC_CODE_VERSION_2 = 2;
    public const int VENDOR_HASH_LENGTH = 7;
    public const uint VLS_ACTIVE_HANDLE = 0x29;
    public const uint VLS_ADD_LIC_CANCELLED_BY_USER = 0xb9;
    public const uint VLS_ADD_LIC_FAILED = 0x13;
    public const uint VLS_ALL_UNITS_RELEASED = 0x27;
    public const uint VLS_AMBIGUOUS_HANDLE = 0x2a;
    public const uint VLS_APP_NODE_LOCKED = 6;
    public const uint VLS_APP_UNNAMED = 2;
    public const uint VLS_BACKUP_CONFIGURATION_ERROR = 0xa7;
    public const uint VLS_BAD_DISTB_CRIT = 0x2e;
    public const uint VLS_BAD_HOSTNAME = 0x33;
    public const uint VLS_BAD_SERVER_MESSAGE = 0x19;
    public const uint VLS_CALL_SEQUENCE_ERROR = 0x9d;
    public const uint VLS_CALLING_ERROR = 11;
    public const uint VLS_CANNOT_DELETE_UPGRADED_LIC = 0x61;
    public const int VLS_CAPACITY_GET = 8;
    public const uint VLS_CAPACITY_MISMATCH = 0xd6;
    public const int VLS_CAPACITY_NON_POOLED = 1;
    public const int VLS_CAPACITY_NONE = 0;
    public const int VLS_CAPACITY_POOLED = 2;
    public const uint VLS_CHECKOUT_NOT_ALLOWED_FROM_NONPRIMARY_LEADER = 0xdd;
    public const uint VLS_CLEAN_NOT_RECOVERABLE = 0xaf;
    public const uint VLS_CLEAN_REPAIR_ATTEMPTED = 0xae;
    public const uint VLS_CLEAN_REPAIR_COMPLETE_LOSS = 0xb2;
    public const uint VLS_CLEAN_REPAIR_FAIL = 0xb1;
    public const uint VLS_CLEAN_REPAIR_NOT_REQUIRED = 0xad;
    public const uint VLS_CLEAN_REPAIR_WITH_LOSS = 0xb3;
    public const uint VLS_CLEAN_WRONG_FILE = 0xb0;
    public const uint VLS_CLIENT_ALREADY_EXIST = 0x4f;
    public const uint VLS_CLIENT_ALREADY_EXISTS = 0x47;
    public const uint VLS_CLIENT_COMMUTER_CODE_DOES_NOT_EXIST = 70;
    public const int VLS_CLIENT_HOST_NAME_ID = 2;
    public const string VLS_CLIENT_HOST_NAME_ID_STRING = "2";
    public const int VLS_CLIENT_NODE_LOCKED = 3;
    public const uint VLS_CLIENT_NOT_AUTHORIZED = 0x2d;
    public const uint VLS_CLK_TAMP_FOUND = 0x1a;
    public const uint VLS_CODE_GENERATOR_LIBRARY_FAILED = 0x98;
    public const int VLS_COMMUTED_CODE = 2;
    public const uint VLS_COMMUTER_CHECKOUT = 0x68;
    public const int VLS_COMMUTER_CLIENT_STORE = 3;
    public const uint VLS_COMMUTER_CODE_ALREADY_EXIST = 0x51;
    public const uint VLS_COMMUTER_CODE_DATE_RESTRICTED = 0xd8;
    public const uint VLS_COMMUTER_CODE_DOES_NOT_EXIST = 80;
    public const int VLS_COMMUTER_GET = 4;
    public const int VLS_COMMUTER_SERVER_STORE = 4;
    public const int VLS_COMMUTERDAYS_UNRESTRICTED = 0;
    public const uint VLS_CONF_FILE_ERROR = 0x40;
    public const uint VLS_CONFIGURATION_NOT_ALLOWED = 0xa1;
    public const int VLS_CONSUME_STORE = 6;
    public const uint VLS_CONTACT_FAILOVER_SERVER = 0x37;
    public const int VLS_CUSTOMEX_SIZE = 0x40;
    public const uint VLS_DELETE_LIC_FAILED = 20;
    public const int VLS_DEMO_MODE = 2;
    public const uint VLS_DIFF_LIB_VER = 0x34;
    public const int VLS_DISC_DEFAULT_OPTIONS = 0;
    public const int VLS_DISC_NO_OPTIONS = 0;
    public const int VLS_DISC_NO_USERLIST = 4;
    public const int VLS_DISC_PRIORITIZED_LIST = 2;
    public const int VLS_DISC_REDUNDANT_ONLY = 8;
    public const int VLS_DISC_RET_ON_FIRST = 1;
    public const uint VLS_DUPLICATE_LICENSE = 0x5d;
    public const int VLS_EH_SET_ALL = 0;
    public const uint VLS_ELM_LIC_NOT_ENABLE = 0x44;
    public const uint VLS_ERROR_FILE_NOT_FOUND = 0xd4;
    public const uint VLS_ERROR_NO_MORE_FINGERPRINT_VALUE = 0xd3;
    public const uint VLS_ERROR_READING_SERVER_CONFIG_FILE = 220;
    public const uint VLS_EXCEEDS_LICENSE_LIFE = 0x57;
    public const uint VLS_EXCEEDS_MAX_SIZE = 0xa2;
    public const uint VLS_EXPIRED_COMMUTER_CODE = 0xd7;
    public const int VLS_FALSE = 1;
    public const uint VLS_FEATURE_INACTIVE = 0x3e;
    public const uint VLS_FEATURE_MARKED_FOR_DELETION = 0x63;
    public const uint VLS_FILE_OPEN_ERROR = 50;
    public const uint VLS_FINGERPRuint_MISMATCH = 0x24;
    public const int VLS_FLOATING = 1;
    public const int VLS_GET_CID = 2;
    public const uint VLS_GET_COMMUTER_INFO_FAILED = 0x49;
    public const int VLS_GET_CUSTOMEX = 4;
    public const int VLS_GET_ETHERNET = 1;
    public const int VLS_GET_HARD_DISK_SERIAL = 8;
    public const uint VLS_GRACE_CODE_LENGTH_OVERFLOW_ERROR = 210;
    public const uint VLS_GRACE_LIC_INSTALL_FAIL = 0x80;
    public const uint VLS_GRACE_LIC_TIME_TAMPER_INIT_FAIL = 0xe3;
    public const uint VLS_GRACE_REMAIN_ON_NONET = 0;
    public const int VLS_GRACE_REQ = 8;
    public const int VLS_GRACE_STORE = 5;
    public const uint VLS_HANDLER_ALREADY_REGISTERED = 0xb7;
    public const int VLS_HOLD_CODE = 2;
    public const string VLS_HOLD_CODE_STRING = "2";
    public const int VLS_HOLD_NONE = 0;
    public const string VLS_HOLD_NONE_STRING = "0";
    public const int VLS_HOLD_VENDOR = 1;
    public const string VLS_HOLD_VENDOR_STRING = "1";
    public const int VLS_HOST_NAME_BASED_TEAM = 2;
    public const string VLS_HOST_NAME_BASED_TEAM_STRING = "2";
    public const uint VLS_HOST_UNKNOWN = 3;
    public const int VLS_IGNORE_GRACE_ERROR = 0;
    public const uint VLS_INFINITE_CAPACITY = uint.MaxValue;
    public const int VLS_INFINITE_KEYS = 0x1ffffe;
    public const string VLS_INFINITE_KEYS_STRING = "";
    public const uint VLS_INSTALL_STORE_NOT_SET = 0x86;
    public const uint VLS_INSUFFICIENT_TEAM_CAPACITY = 0x60;
    public const uint VLS_INSUFFICIENT_USER_CAPACITY = 0x5e;
    public const uint VLS_INTERNAL_ERROR = 12;
    public const uint VLS_INVALID_DOMAIN = 0x1c;
    public const uint VLS_INVALID_FILETYPE = 90;
    public const uint VLS_INVALID_INFO_FROM_CLIENT = 0x4e;
    public const uint VLS_INVALID_IP_ADDRESS = 0x3a;
    public const uint VLS_INVALID_LICENSE = 0x5c;
    public const uint VLS_INVALID_MACHINEID_STR = 0x56;
    public const int VLS_INVALID_STANDALONE_FLAG = -1;
    public const uint VLS_INVALID_TAG_TYPE = 30;
    public const uint VLS_INVALID_TCPIP_VERSION = 0xe1;
    public const uint VLS_ISSUE_COMMUTER_CODE_FAILED = 0x4b;
    public const int VLS_ISSUE_COMMUTER_CODES = 1;
    public const uint VLS_LEADER_NOT_PRESENT = 0x2f;
    public const uint VLS_LIBRARY_ALREADY_INITIALIZED = 0x84;
    public const uint VLS_LIBRARY_NOT_INITIALIZED = 0x83;
    public const uint VLS_LICENSE_ALREADY_REVOKED = 0xbb;
    public const uint VLS_LICENSE_DELETION_NOT_ALLOWED = 0xd5;
    public const uint VLS_LICENSE_IN_USE = 0x8d;
    public const uint VLS_LICENSE_NOT_EXPIRED_AND_HAS_VALID_LOCK_CODE = 0xb5;
    public const uint VLS_LICENSE_NOT_LOCKED = 180;
    public const uint VLS_LICENSE_NOT_PROCESSED = 160;
    public const uint VLS_LICENSE_RECORD_EMPTY = 0xa9;
    public const uint VLS_LICENSE_START_DATE_NOT_REACHED = 0xbc;
    public const int VLS_LICENSE_STATE_ACTIVE = 1;
    public const int VLS_LICENSE_STATE_INACTIVE = 0;
    public const int VLS_LICENSE_STORAGE_MAXPATHLEN = 0x100;
    public const int VLS_LICENSE_STORE = 0;
    public const int VLS_LICENSE_STORE_ALL_RECOVERY_MODES = 15;
    public const int VLS_LICENSE_STORE_CHECK_BACKUP_ON_READ = 8;
    public const int VLS_LICENSE_STORE_CHECK_FILES_ON_OPEN = 1;
    public const int VLS_LICENSE_STORE_CHECK_RECORDS_ON_OPEN = 2;
    public const uint VLS_LICENSE_STORE_FULL = 0x89;
    public const int VLS_LICENSE_STORE_MAX_CAPACITY = 0x3fffff;
    public const int VLS_LICENSE_STORE_MIN_CAPACITY = 1;
    public const int VLS_LICENSE_STORE_NO_RECOVERY = 0;
    public const uint VLS_LICENSE_STORE_QUERY_FAILED = 0x92;
    public const int VLS_LICENSE_STORE_RECOVER_ON_READ = 4;
    public const uint VLS_LICENSE_VERSION_700 = 0x7000000;
    public const uint VLS_LICENSE_VERSION_730 = 0x7030000;
    public const uint VLS_LICENSE_VERSION_7301 = 0x7030001;
    public const uint VLS_LICENSE_VERSION_800 = 0x8000000;
    public const uint VLS_LICENSE_VERSION_810 = 0x8100000;
    public const uint VLS_LICENSE_VERSION_823 = 0x8230000;
    public const uint VLS_LICENSE_VERSION_840 = 0x8400000;
    public const uint VLS_LICENSE_VERSION_LATEST = 0x8400000;
    public const uint VLS_LICENSE_VERSION_NOT_DEFINED = uint.MaxValue;
    public const uint VLS_LICENSE_VERSION_TOO_OLD = 0;
    public const int VLS_LOCAL_REQUEST_LOCKCRIT_DEFINED = 1;
    public const int VLS_LOCAL_REQUEST_LOCKCRIT_USEDEFAULT = 0;
    public const uint VLS_LOCAL_UPDATE = 0x15;

    /* To set a particular locking criterion. */
    public const uint VLS_LOCK_ALL = 0x3f9f;
    public const uint VLS_LOCK_CODE_INVALID = 150;
    public const uint VLS_LOCK_CODE_MISMATCH = 0xb6;
    public const uint VLS_LOCK_CODE_NOT_SUPPORTED = 0x94;
    public const int VLS_LOCK_CODE_SIZE = 0x11;
    public const uint VLS_LOCK_CODE_VER_INVALID = 0x95;
    public const uint VLS_LOCK_CPU_INFO = 0x1000;
    public const uint VLS_LOCK_CPU = 0xC8;
    public const int VLS_LOCK_CUSTOM = 0x100;
    public const int VLS_LOCK_CUSTOMEX = 0x400;
    public const int VLS_LOCK_DISK_ID = 0x4;
    public const int VLS_LOCK_ETHERNET = 0x10;
    public const int VLS_LOCK_HARD_DISK_SERIAL = 0x800;
    public const int VLS_LOCK_HIGHEST_BIT = 14;
    public const int VLS_LOCK_HOSTNAME = 0x8;
    public const int VLS_LOCK_ID_PROM = 0x1;
    public const int VLS_LOCK_IP_ADDR = 0x2;
    public static uint VLS_LOCK_NONET;
    public const int VLS_LOCK_NW_IPX = 0x20;
    public const int VLS_LOCK_NW_SERIAL = 0x40;
    public const int VLS_LOCK_PORTABLE_SERV = 0x80;
    public const uint VLS_LOCK_SELECTOR_INVALID = 0x93;
    public const uint VLS_LOCK_UUID = 0x2000;

    public const uint VLS_LOG_FILE_NAME_NOT_CHANGED = 0x23;
    public const uint VLS_LOG_FILE_NAME_NOT_FOUND = 0x22;
    public const int VLS_LOGCOMMENTLEN = 100;
    public static int VLS_MACHINEID_STRING_SIZE;
    public const uint VLS_MAJORITY_RULE_FAILURE = 0x3f;
    public const int VLS_MAJORITY_RULE_FOLLOWS = 1;
    public const int VLS_MAJORITY_RULE_NOT_FOLLOWS = 0;
    public const int VLS_MAX_BUF_LEN = 0x400;
    public const int VLS_MAX_CHAL_DATA = 30;
    public const int VLS_MAX_CONTEXT_LEN = 0xff;
    public const int VLS_MAX_CPU_ID_LEN = 0x18;
    public const uint VLS_MAX_CPU_INFO_LEN = 0x400;
    public const int VLS_MAX_CUSTOM_LICENSE_SIZE = 0x28a0;
    public const int VLS_MAX_CUSTOMEX_COUNT = 8;
    public const int VLS_MAX_ENCRYPTION_LEVEL = 4;
    public const int VLS_MAX_LICENSE_HASH_LEN = 0x11;
    public const int VLS_MAX_LICENSE_REVOCATION_TICKET_SIZE = 0x400;
    public const int VLS_MAX_LICENSE_SIZE = 0x1450;
    public const int VLS_MAX_NAME_LEN = 0x80;
    public const int VLS_MAX_RESP_DATA = 0x10;
    public const uint VLS_MAX_UUID_LEN = 0x24;
    public const int VLS_MAXCLLOCKLEN = 200;
    public const int VLS_MAXFEALEN = 0x40;
    public const int VLS_MAXFEALEN_API_USER = 0x19;
    public const int VLS_MAXLEN = 0x40;
    public const int VLS_MAXPATHLEN = 0x100;
    public const int VLS_MAXSRVLOCKLEN = 250;
    public const int VLS_MAXVERLEN = 12;
    public const uint VLS_MSG_TO_LEADER = 0x36;
    public const uint VLS_MULTIPLE_VENDORID_FOUND = 0x18;
    public const int VLS_NETWORK_MODE = 0;
    public const uint VLS_NETWORK_SRVR = 0x66;
    public const uint VLS_NEW_RECORD_FOUND = 0xd9;
    public const uint VLS_NO_ACTIVE_HANDLE = 130;
    public const uint VLS_NO_AVAILABLE_MACHINE_ID = 0x97;
    public const int VLS_NO_EXPIRATION = -1;
    public const int VLS_NO_GRACE_PERIOD = 0;
    public const uint VLS_NO_KEY_TO_RETURN = 7;
    public const uint VLS_NO_LICENSE_GIVEN = 1;
    public const uint VLS_NO_MATCH_FOUND = 0xe0;
    public const uint VLS_NO_MORE_CLIENTS = 9;
    public const uint VLS_NO_MORE_COMMUTER_CODE = 0x48;
    public const uint VLS_NO_MORE_FEATURES = 10;
    public const uint VLS_NO_MORE_LICENSE_STORES = 0x87;
    public const uint VLS_NO_MORE_LICENSES = 0x8b;
    public const uint VLS_NO_MORE_RECORDS = 0x9f;
    public const int VLS_NO_OVERDRAFT = 0;
    public const uint VLS_NO_RECORDS_FOUND = 0xda;
    public const uint VLS_NO_RESPONSE_TO_BROADCAST = 0x11;
    public const uint VLS_NO_SERVER_FILE = 4;
    public const uint VLS_NO_SERVER_RESPONSE = 14;
    public const uint VLS_NO_SERVER_RUNNING = 5;
    public const int VLS_NO_SHARING = 0;
    public const string VLS_NO_SHARING_STRING = "0";
    public const uint VLS_NO_SUCH_CLIENT = 0x2c;
    public const uint VLS_NO_SUCH_FEATURE = 0x12;
    public const uint VLS_NO_SUCH_LICENSE = 140;
    public const uint VLS_NO_SUCH_LICENSE_STORE = 0x88;
    public const int VLS_NO_TEAM = 0;
    public const string VLS_NO_TEAM_STRING = "0";
    public const int VLS_NO_TRACE = 0;
    public const uint VLS_NO_TRIAL_INFO = 0x42;
    public const uint VLS_NO_UPDATE_REQUIRED = 0xba;
    public const uint VLS_NO_UPDATES_SO_FAR = 0x26;
    public const int VLS_NODE_LOCKED = 0;
    public const string VLS_NOLIMIT_STRING = "NOLIMIT";
    public const uint VLS_NOMORE_QUEUE_RESOURCES = 0x2b;
    public const int VLS_NON_REDUNDANT_CODE = 0;
    public const uint VLS_NON_REDUNDANT_FEATURE = 0x41;
    public const uint VLS_NON_REDUNDANT_SRVR = 0x35;
    public const uint VLS_NON_TRIAL_LICENSE = 0xb8;
    public const uint VLS_NONET_LIBRARY = 0xa5;
    public const int VLS_NORMAL_LIC = 0;
    public const uint VLS_NOT_AUTHORIZED = 0x1b;
    public const uint VLS_NOT_ENOUGH_COMMUTER_KEYS_AVAILABLE = 0x4d;
    public const uint VLS_NOT_ENOUGH_LOCK_FIELDS = 0x7e;
    public const int VLS_NOT_ISSUE_COMMUTER_CODES = 0;
    public const uint VLS_NOT_LINKED_TO_INTEGRATED_LIBRARY = 0x45;
    public const uint VLS_NOT_SUPPORTED = 0x5b;
    public const uint VLS_NOT_SUPPORTED_IN_NET_ONLY_MODE = 0x59;
    public const uint VLS_NOT_SUPPORTED_IN_NONET_MODE = 0x81;
    public const int VLS_NOTIFY_GRACE_ERROR = 1;
    public const uint VLS_NULL_VALUE_PARAMETER = 500;
    public const int VLS_OFF = 0;
    public const int VLS_ON = 1;
    public const uint VLS_ONLY_SERVER = 0x3d;
    public const uint VLS_OPERATION_NOT_SUCCESSFUL = 0xdb;
    public const uint VLS_PERPETUAL_LICENSE = 0x67;
    public const int VLS_PERPETUAL_MODE = 2;
    public const uint VLS_PERSISTENCE_CONFIGURATION_ERROR = 0xa4;
    public const uint VLS_PERSISTENCE_STORE_FULL = 0xac;
    public const int VLS_PERSISTENCE_STORE_MAX_CAPACITY = 0x1fffff;
    public const int VLS_PERSISTENCE_STORE_MIN_CAPACITY = 1;
    public const uint VLS_POOL_FULL = 60;
    public const int VLS_PRECEDENCE_DEFAULT = 1;
    public const int VLS_PRECEDENCE_DISABLE = 0;
    public const int VLS_PRECEDENCE_TRIAL_OVERRIDE_NORMAL = -1;
    public const uint VLS_PUBLIC_VENINFOLEN = 0x18b;
    public const uint VLS_QUEUED_HANDLE = 40;
    public const uint VLS_RECORD_CORRUPT = 0xa8;
    public const uint VLS_RECORD_NOT_FOUND = 0x9e;
    public const int VLS_REDUNDANT_CODE = 1;
    public const uint VLS_REHOST_ALLOCATE_MEMORY_FAILURE = 200;
    public const uint VLS_REHOST_BUFFER_TOO_SMALL = 0xc1;
    public const uint VLS_REHOST_BUFFER_TOO_SMALL_UNEXPECTED = 0xc2;
    public const uint VLS_REHOST_CANCELED_BY_USER = 0xd0;
    public const uint VLS_REHOST_DIFFERENT_LOCK_INFO = 0xca;
    public const uint VLS_REHOST_HAVE_BEEN_REVOKED_BEFORE = 0xcd;
    public const uint VLS_REHOST_INVALID_DATA_FORMAT = 0xc5;
    public const uint VLS_REHOST_INVALID_REQUEST_DATA = 0xc6;
    public const uint VLS_REHOST_LIC_VERSION_NOT_SUPPORTED = 0xde;
    public const uint VLS_REHOST_LICENSE_EXIST = 0xcf;
    public const uint VLS_REHOST_LICENSE_IN_USE = 0xcb;
    public const uint VLS_REHOST_PARAMETERS_ERROR = 0xc3;
    public const uint VLS_REHOST_REVOKE_OVER_TOTAL = 0xce;
    public const uint VLS_REHOST_STATUS_NOT_DEFINED = 0xd1;
    public const uint VLS_REHOST_TAG_NOT_FOUND = 0xc9;
    public const uint VLS_REHOST_UNEXPECTED_ERROR = 0xcc;
    public const uint VLS_REHOST_UNSUPPORTED_ALGO = 0xc4;
    public const uint VLS_REHOST_UNSUPPORTED_OPERATION_TYPE = 0xc7;
    public const uint VLS_REMOTE_CHECKOUT = 0x53;
    public const uint VLS_REMOTE_CHECKOUT_NOT_ALLOWED_FOR_PERPETUAL = 0x7f;
    public const uint VLS_REMOTE_UPDATE = 0x16;
    public const int VLS_REQ_GET = 1;
    public const int VLS_REQ_GET_SW = 0x10;
    public const int VLS_REQ_QUEUE = 2;
    public const uint VLS_REQUIRED_LOCK_FIELDS_NOT_FOUND = 0x7d;
    public const uint VLS_RESOURCE_LOCK_FAILURE = 0x85;
    public const uint VLS_RETURN_FAILED = 8;
    public const int VLS_REVOCATION_STORE = 2;
    public const uint VLS_REVOKE_ERR_CAPACITY_LIC_UNSUPPORED = 0x7a;
    public const uint VLS_REVOKE_ERR_CODGEN_VERSION_UNSUPPORTED = 120;
    public const uint VLS_REVOKE_ERR_CORRUPT_MESSAGE = 0x6a;
    public const uint VLS_REVOKE_ERR_INFINITE_GRP_DIST = 0x74;
    public const uint VLS_REVOKE_ERR_INFINITE_LIC_FINITE_REQ = 0x76;
    public const uint VLS_REVOKE_ERR_INFINITE_LIC_IN_USE = 0x75;
    public const uint VLS_REVOKE_ERR_INSUFFICIENT_DEFAULT_GROUP = 0x6f;
    public const uint VLS_REVOKE_ERR_INSUFFICIENT_FEATURE_LICENSES = 110;
    public const uint VLS_REVOKE_ERR_INSUFFICIENT_FREE_IN_DEFAULT = 0x70;
    public const uint VLS_REVOKE_ERR_INVALID_PASSWORD = 0x72;
    public const uint VLS_REVOKE_ERR_INVALID_SESSION_ID = 0x71;
    public const uint VLS_REVOKE_ERR_MD5_PLUGIN_EXEC_FAIL = 0x6d;
    public const uint VLS_REVOKE_ERR_MD5_PLUGIN_LOAD_FAIL = 0x6c;
    public const uint VLS_REVOKE_ERR_NO_FEATURE = 0x69;
    public const uint VLS_REVOKE_ERR_OUT_VALID_RANGE = 0x6b;
    public const uint VLS_REVOKE_ERR_RDNT_LIC_UNSUPPORED = 0x79;
    public const uint VLS_REVOKE_ERR_TICKET_GENERATION = 0x77;
    public const uint VLS_REVOKE_ERR_TRIAL_LIC_UNSUPPORED = 0x7c;
    public const uint VLS_REVOKE_ERR_uintERNAL_SERVER = 0x73;
    public const uint VLS_REVOKE_ERR_UNEXPECTED_AUTH_CHLG_PKT = 0x7b;
    public const uint VLS_SAVE_LICENSE_FILE_ALREADY_EXISTS = 0xab;
    public const uint VLS_SAVE_LICENSE_FILE_WRITE_ERROR = 170;
    public const int VLS_SERV_LOCALE_STR_LEN = 0x23;
    public const int VLS_SERV_PLATFORM_STR_LEN = 20;
    public const int VLS_SERV_UNUSED1_STR_LEN = 20;
    public const int VLS_SERV_VNDINFO_STR_LEN = 50;
    public const uint VLS_SERVER_ALREADY_PRESENT = 0x30;
    public const uint VLS_SERVER_FILE_SYNC = 0x3b;
    public const uint VLS_SERVER_NOT_PRESENT = 0x31;
    public const uint VLS_SERVER_SYNC_IN_PROGRESS = 0x52;
    public const uint VLS_SET_LICENSE_PRECEDENCE_FAILED = 0x8e;
    public const uint VLS_SEVERE_INTERNAL_ERROR = 13;
    public const int VLS_SITEINFOLEN = 150;
    public const string VLS_STANDALONE = "no-net";
    public const int VLS_STANDALONE_MODE = 1;
    public const int VLS_STANDARD_GRACE_PERIOD = 1;
    public const int VLS_STANDARD_OVERDRAFT = 1;
    public const uint VLS_STORE_ACCESS_ERROR = 0x8f;
    public const uint VLS_STORE_ALREADY_EXISTS = 0xa6;
    public const uint VLS_STORE_DATA_INCONSISTENT = 0x90;
    public const uint VLS_STORE_OPEN_ERROR = 0x91;
    public const uint VLS_STORE_SIZE_TOO_SMALL = 0x8a;
    public const uint VLS_SYSTEM_EXCEPTION = 0x1f5;
    public const uint VLS_TAGS_NOT_SUPPORTED = 0x21;
    public const uint VLS_TEAM_EXCLUDED = 0x65;
    public const uint VLS_TEAM_LIMIT_EXHAUSTED = 0x5f;
    public const uint VLS_TERMINAL_SERVER_FOUND = 0x58;
    public const int VLS_TRACE_ALL = 7;
    public const int VLS_TRACE_DEFAULT = 0;
    public const int VLS_TRACE_ERRORS = 4;
    public const int VLS_TRACE_FUNCTIONS = 2;
    public const int VLS_TRACE_KEYS = 1;
    public const int VLS_TRIAL_ACTIVE = 1;
    public const int VLS_TRIAL_DATA_MAX_UPDATETIME = 0x5a0;
    public const int VLS_TRIAL_DATA_MIN_UPDATETIME = 1;
    public const int VLS_TRIAL_DAYSCNT_DISABLED = 0;
    public const int VLS_TRIAL_ELAPSEDHOURS_DISABLED = 0;
    public const int VLS_TRIAL_EXECUTIONCNT_DISABLED = 0;
    public const int VLS_TRIAL_EXHAUSTED = 2;
    public const uint VLS_TRIAL_INFO_FAILED = 0x43;
    public const int VLS_TRIAL_LIC = 1;
    public const uint VLS_TRIAL_LIC_DATA_ACCESS_ERROR = 0x99;
    public const uint VLS_TRIAL_LIC_DATA_INCONSISTENT = 0x9a;
    public const uint VLS_TRIAL_LIC_DATE_RESTRICTED = 0x9b;
    public const uint VLS_TRIAL_LIC_EXHAUSTED = 0x25;
    public const uint VLS_TRIAL_LIC_NOT_ACTIVATED = 0x9c;
    public const int VLS_TRIAL_STORE = 1;
    public const int VLS_TRIAL_UNUSED = 0;
    public const int VLS_TRUE = 0;
    public const uint VLS_UNABLE_TO_GET_MACHINE_ID_STRING = 0x55;
    public const uint VLS_UNABLE_TO_INSTALL_COMMUTER_CODE = 0x54;
    public const uint VLS_UNABLE_TO_ISSUE_COMMUTER_CODE = 0x4c;
    public const uint VLS_UNABLE_TO_UNINSTALL_CLIENT_COMMUTER_CODE = 0x4a;
    public const uint VLS_UNKNOWN_SHARED_ID = 0x10;
    public const uint VLS_UNKNOWN_TAG = 0x1f;
    public const uint VLS_UNKNOWN_TAG_TYPE = 0x1d;
    public const int VLS_UNLIMITED_OVERDRAFT_HOURS = 0;
    public const uint VLS_UNRESOLVED_HOSTNAME = 0x39;
    public const uint VLS_UNRESOLVED_IP_ADDRESS = 0x38;
    public const uint VLS_UPDATE_TAGGED_KEY_ERROR = 0x20;
    public const uint VLS_UPGRADE_NOT_ALLOWED = 0x62;
    public const uint VLS_USAGE_FILE_TAMPERED = 0xdf;
    public const uint VLS_USER_EXCLUDED = 15;
    public const int VLS_USER_NAME_BASED_TEAM = 1;
    public const string VLS_USER_NAME_BASED_TEAM_STRING = "1";
    public const int VLS_USER_NAME_ID = 1;
    public const string VLS_USER_NAME_ID_STRING = "1";
    public const uint VLS_VALUE_OUT_OF_RANGE = 0xa3;
    public const int VLS_VENDOR_DEFINED_TEAM = 4;
    public const string VLS_VENDOR_DEFINED_TEAM_STRING = "4";
    public const int VLS_VENDOR_SHARED_ID = 4;
    public const string VLS_VENDOR_SHARED_ID_STRING = "4";
    public const uint VLS_VENDORIDMISMATCH = 0x17;
    public const int VLS_VENINFOLEN = 0x7d0;
    public const uint VLS_VENINFOLEN_810 = 0x18b;
    public const int VLS_VENINFOLEN_OLD = 0x62;
    public const uint VLS_VIRTUAL_MACHINE_IS_DETECTED = 0xe2;
    public const int VLS_X_DISPLAY_BASED_TEAM = 3;
    public const string VLS_X_DISPLAY_BASED_TEAM_STRING = "3";
    public const int VLS_X_DISPLAY_NAME_ID = 3;
    public const string VLS_X_DISPLAY_NAME_ID_STRING = "3";
    public const int VLS_YES_NO_BUFFER_SIZE = 2;
    public const int VLScg_MAX_CODE_COMP_LEN = 0x200;

    public enum CONSUME_LIMIT_TYPE
    {
        VLS_LIMIT_TYPE_DURATION = 2,
        VLS_LIMIT_TYPE_VOLUME = 1
    }

    public enum CONSUME_OPERATION_TYPE
    {
        VLS_RESET = 2,
        VLS_SET = 1
    }

    public enum srvrLogState
    {
        LOG_ADD_DEL_LIC = 11,
        LOG_BORROW_REQ_RESP = 4,
        LOG_CFG_FILE = 8,
        LOG_CHNG_DIST_CRIT = 6,
        LOG_DIST_CRIT_SYNC = 7,
        LOG_HRT_BT = 3,
        LOG_LDR_ELECT = 2,
        LOG_MOD_SERVER = 10,
        LOG_SRVR_DOWN = 9,
        LOG_SRVR_UP = 1,
        LOG_USG_NOTIFY = 5
    }

    public enum VLS_ERR_FILE
    {
        VLS_NULL,
        VLS_STDOUT,
        VLS_STDERR
    }

    public enum VLS_FILE_TYPE
    {
        VLS_LSERVRC,
        VLS_LSERVRCCNF,
        VLS_ULSERVRC,
        VLS_GENERICCONF
    }

    public enum VLS_LOC_UPD_STAT
    {
        VLS_LOCAL_UPD_ENABLE,
        VLS_LOCAL_UPD_DISABLE
    }

    public enum VLS_VM_DETECTION
    {
        VLS_VIRTUAL_MACHINE_ALLOWED,
        VLS_VIRTUAL_MACHINE_DISALLOWED
    }

    public enum VLS_VM_DETECTION_STATE
    {
        VLS_NO_VIRTUAL_MACHINE_DETECTED,
        VLS_VIRTUAL_MACHINE_DETECTED
    }

    public enum VLSactionOnTmTamper
    {
        VLS_CONT_AFTER_TM_TAMPER,
        VLS_EXIT_AFTER_TM_TAMPER
    }

    public enum VLStmTamperMethod
    {
        VLS_ENABLE_DEFAULT_TM_TAMPER,
        VLS_DISABLE_DEFAULT_TM_TAMPER
    }

    }
}
