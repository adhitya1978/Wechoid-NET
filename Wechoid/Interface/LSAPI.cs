using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using Wechoid.Structure;
using Wechoid.Const;

namespace Wechoid.Interface
{
   public class LSAPI
    {
       private const string LibraryName = "lsapiw32.dll";
       
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint LSGetMessage(int lshandle, int Value, StringBuilder Buffer, uint BufferSize);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint LSRelease(int handle, uint UnitsReqd, string LogComment);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint LSRequest(string LicenseSystem, string PublisherName, string FeatureName, string Version, ref uint UnitsReqd, string LogComment, ref CHALLENGE challenge, ref int lshandle);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint LSUpdate(int lshandle, uint ulGraceSwitchToNetworkTm, ref int unused2, string unused3, ref CHALLENGE unused4);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSaddFeature(string license_string, string unused1, ref CHALLENGE unused2);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSaddFeatureExt(string licenseString, string DistCritString, string log_comment, ref CHALLENGE challenge);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSaddFeatureToFile(string license_string, string unused1, string unused2, ref CHALLENGE unused3);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSaddFeatureToFileExt(string licenseString, string DistCritString, string license_file_name, string log_comment, ref CHALLENGE challenge);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSaddServerToPool(string server_name, string server_addr);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSbatchUpdate(int numHandles, int[] lshandle, ref uint unused1, ref int unused2, string unused3, ref CHALLENGE unused4, int[] status);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLScalculateLicenseHash(string pcLicenseString, StringBuilder pucLicenseHash, ref int piLicenseHashLength);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSchangeDistbCrit(string feature_name, string feature_version, string dist_crit);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSchangeUsageLogFileName(string hostname, string newFileName);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLScleanExpiredCommuterCode(string feature_name, string feature_version, string log_comment, ref int unused);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLScleanup();
       [DllImport("WrapDotNet.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLScompareB(ref CHALLENGE challenge, ref CHALLENGE challengeResponse, string secret);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLScontrolRemoteSession(int toCheckRemoteSession);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSdeleteFeature(string feature_name, string version, string unused1, ref CHALLENGE unused2);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSdeleteFeatureExt(string feature_name, string version, [MarshalAs(UnmanagedType.AsAny)] object capacity, string log_comment, ref CHALLENGE challenge, string unused1, ref uint unused2);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSdeleteLicenseFromFile(string feature_name, string version, string license_hash, int license_hash_len, StringBuilder license_string, ref uint license_string_bufsize, ref int unused1, int unused2);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSdeleteLicenseFromFileExt(string feature_name, string version, [MarshalAs(UnmanagedType.AsAny)] object puiCapacity, string license_hash, int license_hash_len, StringBuilder license_string, ref int license_string_bufsize, ref int unused1, int unused2);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSdelServerFromPool(string server_name, string server_addr);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSdestroyHandleInClient(int lshandle);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSdisableAutoTimer(int handle, int state);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSdisableLicense(ref int handle);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSdisableLocalRenewal();
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSdiscover(string feature_name, string version, string unused1, int bufferSize, StringBuilder server_names, int broadcastFlag, string vendor_list);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSdiscoverExt(string feature_name, string version, string unused1, ref int num_servers, ref VLSdiscoverInfo[] discoverInfo, int optionFlag, int sharing_crit, StringBuilder vendor_list);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSenableLocalRenewal();
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSerrorHandle(int errorHandle);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetActiveHandleList(ref int[] outHandleBuf, ref uint numHandle);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetAndInstallCommuterCode(string feature_name, string feature_version, ref uint units_reqd, ref int duration, ref int lock_mask, string log_comment, ref CHALLENGE challenge);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern int VLSgetBroadcastInterval();
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetCapacityFromHandle(int lshandle, ref uint user_capacity, ref uint team_capacity, ref uint license_capacity);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetCapacityList(string feature_name, string feature_version, ref int index, ref int bufferSize, StringBuilder capacityList, string log_comment, ref uint unused2);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetClientInfo(string feature_name, string version, int index, string unused, ref VLSClientInfo client_info);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetClientInfoExt(string feature_name, string version, [MarshalAs(UnmanagedType.AsAny)] object capacity, int index, string log_comment, ref uint unused1, ref VLSClientInfo client_info);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetCommuterCode(string feature_name, string feature_version, ref int units_reqd, ref int duration, ref uint lock_mask, string log_comment, string machineIDString, StringBuilder commuter_code, ref CHALLENGE challenge, ref VLSserverInfo requestInfo, ref VLSserverInfo commuterInfo, [MarshalAs(UnmanagedType.AsAny)] object extension_in_duration);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetCommuterInfo(string feature_name, string feature_version, int index, ref VLScommuterInfo commuter_info);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetConsumeLimit(int iHandle, Wechoid.Const.Const.CONSUME_LIMIT_TYPE consume_type, ref int consume_value, ref CHALLENGE challenge);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetContactServer(StringBuilder outBuf, int outBufSz);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetContextData(int iHandle, StringBuilder context_buff, uint buff_len, ref CHALLENGE challenge);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetDistbCrit(string feature_name, string feature_version, StringBuilder dist_crit, int distcrit_buflen);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetDistbCritToFile(string feature_name, string feature_version, string file_name);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetFeatureFromHandle(int handle, StringBuilder Buffer, uint Buffer_length);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetFeatureInfo(string feature_name, string version, int index, string unused, ref VLSFeatureInfo feature_info);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetFeatureInfoExt(string feature_name, string version, [MarshalAs(UnmanagedType.AsAny)] object capacity, int index, string unused1, ref uint unused2, ref VLSFeatureInfo feature_info);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetFeatureTimeLeftFromHandle(int lshandle, ref uint secondsUntilTheFeatureExpires);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetGraceRequestFlag();
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetHandleInfo(int lshandle, ref VLSClientInfo client_info);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetHandleStatus(int lshandle);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetKeyTimeLeftFromHandle(int lshandle, ref uint secondsUntilTheKeyExpires);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetLastErrorStatusFromHandle(int lshandle, ref int status_code);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetLeaderServerName(StringBuilder leader_name, int leader_name_len);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetLibInfo(ref LS_LIBVERSION pInfo);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetLicenseInfo(string feature_name, string version, int feature_index, string license_hash, int license_hash_len, int license_index, ref VLSlicenseInfo licenseInfo);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetLicenseInfoExt(string feature_name, string version, [MarshalAs(UnmanagedType.AsAny)] object capacity, int feature_index, string license_hash, int license_hash_len, int license_index, ref VLSlicenseInfo licenseInfo);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetLicInUseFromHandle(int lshandle, ref int totalKeysIssued);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetLicSharingServerList(string feature_name, string feature_version, int server_list_len, StringBuilder server_list, ref int num_servers);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetMachineID(uint lock_selector_in, ref VLSmachineID machineID, ref uint lock_selector_out);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetMachineIDOld(uint lock_selector_in, ref VLSmachineID machineID, ref uint lock_selector_out);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetMachineIDString(ref int lock_selector, StringBuilder machineIDString, ref int bufSz);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetNumberedMachineID(uint lock_selector_in, ref VLSmachineID machineID, ref uint lock_selector_out, int flag, int index, int reserved);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetNumberedMachineIDExt(string server_name, uint lock_selector_in, ref VLSmachineID machineID, ref uint lock_selector_out, int flag, int index, int reserved);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetOutputCP(ref int cp);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetPoolServerList(StringBuilder outBuf, int outBufSz);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetQueuedClientInfo(string feature_name, string version, int index, string unused1, ref VLSqueuedClientInfo client_info);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetQueuedLicense(int lshandle, string log_comment, ref CHALLENGE unused4);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetRenewalStatus();
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetServerList(StringBuilder outBuf, int outBufSz);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetServerNameFromHandle(int handle_id, StringBuilder outBuf, int outBufSz);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetServerPort();
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetServInfo(string server_name, ref VLSservInfo srv_info, string unused1, int unused2);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetTimeDriftFromHandle(int lshandle, ref int secondsServerAheadOfClient);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern int VLSgetTimeoutInterval();
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetTrialPeriodLeft(string feature_name, string version, ref uint trialperiod, string unused1);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetTrialUsageInfo(string feature_name, string version, int feature_index, ref VLStrialUsageInfo trial_usage_info);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetUsageLogFileName(string hostname, StringBuilder fileName);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetVersionFromHandle(int lshandle, StringBuilder Buffer, uint BufferSize);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSgetVersions(string feature_name, int bufferSize, StringBuilder versionList, string unused1);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSinitialize();
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSinitMachineID(ref VLSmachineID machineID);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSinitQueuePreference(ref VLSqueuePreference qPreference);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSinitServerInfo(ref VLSserverInfo serverInfo);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSinitServerList(string ServerList, int option_flag);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSinstallCommuterCode(string commuter_code, string reserved1, uint reserved2);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern Wechoid.Const.Const.VLS_LOC_UPD_STAT VLSisLocalRenewalDisabled();
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSisVirtualMachine(ref VLSVMInfo vm_info);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSlicense(string FeatureName, string Version, ref int handle);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSmachineIDtoLockCode(ref VLSmachineID machineID, uint lock_selector, ref uint lockCode);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSmachineIDToLockCodeEx(ref VLSmachineID machineID, uint lock_selector, StringBuilder lockCode, int lockCodeLen, int unusesd);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSqueuedRequest(string license_system, string publisher_name, string product_name, string version, ref int units_reqd, string log_comment, ref CHALLENGE challenge, ref int lshandle, ref VLSqueuePreference qPreference, ref int requestFlag);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSqueuedRequestExt(string license_system, string publisher_name, string product_name, string version, ref uint units_reqd, string log_comment, ref CHALLENGE challenge, ref int lshandle, ref VLSqueuePreference qPreference, ref int requestFlag, ref VLSserverInfo serverInfo);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSreleaseExt(int lshandle, uint units_consumed, string log_comment, ref VLSserverInfo serverInfo);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSremoveQueue(string feature_name, string version, string log_comment);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSremoveQueuedClient(string feature_name, string version, int qkey_id, string log_comment);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSrequestExt(string license_system, string publisher_name, string product_name, string version, ref uint units_reqd, string log_comment, ref CHALLENGE challenge, ref int lshandle, ref VLSserverInfo serverInfo);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSrequestExt2(string license_system, string publisher_name, string product_name, string version, ref uint units_reqd, string log_comment, ref CHALLENGE challenge, ref int lshandle, ref VLSserverInfo serverInfo, [MarshalAs(UnmanagedType.AsAny)] object team_capacity_reqd, [MarshalAs(UnmanagedType.AsAny)] object capacity_reqd, string unused1, ref uint special_flag);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSrevokeByPermissionTicket(string pucServerName, string pucPassword, StringBuilder pucPermissionTicket, uint ui16PermissionTicketLength, StringBuilder pucRevocationTicket, ref uint pui16RevocationTicketLength);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSrevokeByPermissionTicket(string pucServerName, string pucPassword, byte[] pucPermissionTicket, uint ui16PermissionTicketLength, byte[] pucRevocationTicket, ref uint pui16RevocationTicketLength);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSrevokeLicense(string server_name, string feature_name, string feature_version, [MarshalAs(UnmanagedType.AsAny)] object capacity, string password, ref int units_to_revoke, [MarshalAs(UnmanagedType.AsAny)] object capacity_to_revoke, StringBuilder rvk_ticket, ref int length_of_rvk_ticket, string log_comment, ref uint reserved1, string reserved2);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSsetBroadcastInterval(int interval);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSsetConsumeLimit(int iHandle, Wechoid.Const.Const.CONSUME_LIMIT_TYPE consume_type, Wechoid.Const.Const.CONSUME_OPERATION_TYPE consume_op_type, ref int consume_value, ref CHALLENGE challenge);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSsetContactServer(string server_name);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSsetContextData(int iHandle, string context_buff, uint buff_len, ref CHALLENGE challenge);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSsetCustomExFunc(VLSsetCustomExFuncDelegate pmyGetCustExTableFunc);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSsetErrorHandler(VLSsetErrorHandlerDelegate del, int LS_ErrorType);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSsetFileName(Wechoid.Const.Const.VLS_FILE_TYPE filetype, string fileName, string unused1, ref uint unused2);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSsetGraceRequestFlag(int state);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSsetHoldTime(string feature_name, string version, int hold_time);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSsetHostIdFunc(VLSsetmyHostIdFunc del);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSsetLicensePrecedence(string feature_name, string version, string license_hash, int license_hash_len, int precedence_level, ref int unused1, int unused2);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSsetOutputCP(int cp);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSsetRemoteRenewalTime(string feature_name, string version, int renewal_time);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSsetServerLogState(int _event, int state);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern void VLSsetServerPort(int port_number);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSsetSharedIdValue(int shared_id, string sharedIdValue);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSsetTimeoutInterval(int interval);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSsetTraceHandler(VLSsetTraceHandlerDelegate TraceHandlerDelegate);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSsetTraceLevel(int trace_level);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSsetUserErrorFile(Wechoid.Const.Const.VLS_ERR_FILE msgFile, string filePath);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSsetUserTraceFile(int msgFile, string filePath);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSshutDown(string hostname);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSuninstallAndReturnCommuterCode(string feature_name, string feature_version, string log_comment);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSupdateQueuedClient(int lshandle, ref int absExpiryTime, string unused3, ref CHALLENGE unused4);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSusageAuthenticate(string file_name, ref int len, ref VLSerrorLine[] error_line);
       [DllImport("lsapiw32.dll", CharSet = CharSet.Ansi)]
       public static extern uint VLSusageFileDecrypt(string file_name, string Option_field, string Output_file_name);

       public delegate uint VLSsetCustomExFuncDelegate(ref VLScustomEx pCustomExTable, ref uint pulCount);

       public delegate int VLSsetErrorHandlerDelegate(int ErrorNumber, string featureName);

       public delegate uint VLSsetmyHostIdFunc();

       public delegate uint VLSsetTraceHandlerDelegate(int traceLevel, string buffer, int bufferSize);

    }
}
