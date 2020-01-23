using System;
using System.Collections.Generic;
using System.Text;
using Wechoid.Structure;
using Wechoid.Const;
using System.Collections;
using System.Runtime.InteropServices;
using Wechoid.Interface;

namespace Wechoid.SDKCore
{
  public  class RMSCore
    {
      private string GetErrorMsgString(uint Status)
      {
          string str;
          StringBuilder buffer = new StringBuilder(0x400);
          try
          {
              this.LSGetMessage(0, (int)Status, ref buffer);
              str = buffer.ToString();
          }
          catch (Wechoid.Exception.CoreException exception)
          {
              throw exception;
          }
          return str;
      }

        public uint LSGetMessage(int lshandle, int Value, ref StringBuilder Buffer)
        {
            uint num3;
            if (Buffer == null)
            {
                throw new Wechoid.Exception.CoreException(500, "Error[500]: API called with null value for parameter buffer:LSGetMessage");
            }
            uint errorCode = 0;
            try
            {
                uint bufferSize = 0x400;
                StringBuilder buffer = new StringBuilder(0x400);
                errorCode = LSAPI.LSGetMessage(0, Value, buffer, bufferSize);
                Buffer = buffer;
                if (errorCode == 0xc8001009)
                {
                    Buffer = new StringBuilder("bufferSize is 0. Cannot print the error message.");
                }
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, Buffer.ToString());
                }
                num3 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":LSGetMessage");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":LSGetMessage");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":LSGetMessage");
            }
            return num3;
        }

        public uint LSRelease(int handle, uint UnitsReqd, string LogComment)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.LSRelease(handle, UnitsReqd, LogComment);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":LSRelease");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":LSRelease");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":LSRelease");
            }
            return num2;
        }

        public uint LSRequest(string LicenseSystem, string PublisherName, string FeatureName, string Version, ref uint UnitsReqd, string LogComment, ref object challenge, ref int lshandle)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                CHALLENGE challenge2 = new CHALLENGE();
                if (challenge != null)
                {
                    challenge2 = (CHALLENGE)challenge;
                }
                errorCode = LSAPI.LSRequest(LicenseSystem, PublisherName, FeatureName, Version, ref UnitsReqd, LogComment, ref challenge2, ref lshandle);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                if (challenge != null)
                {
                    challenge = challenge2;
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":LSRequest");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":LSRequest");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":LSRequest");
            }
            return num2;
        }

        public uint LSUpdate(int lshandle, ref object challenge)
        {
            uint num3;
            uint errorCode = 0;
            try
            {
                CHALLENGE challenge2 = new CHALLENGE();
                if (challenge != null)
                {
                    challenge2 = (CHALLENGE)challenge;
                }
                int num2 = 0;
                errorCode = LSAPI.LSUpdate(lshandle, (uint)num2, ref num2, null, ref challenge2);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                if (challenge != null)
                {
                    challenge = challenge2;
                }
                num3 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":LSUpdate");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":LSUpdate");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":LSUpdate");
            }
            return num3;
        }

        public uint LSUpdate(int lshandle, uint ulGraceSwitchToNetworkTm, ref object challenge)
        {
            uint num3;
            uint errorCode = 0;
            try
            {
                CHALLENGE challenge2 = new CHALLENGE();
                if (challenge != null)
                {
                    challenge2 = (CHALLENGE)challenge;
                }
                int num2 = 0;
                errorCode = LSAPI.LSUpdate(lshandle, ulGraceSwitchToNetworkTm, ref num2, null, ref challenge2);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                if (challenge != null)
                {
                    challenge = challenge2;
                }
                num3 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":LSUpdate");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":LSUpdate");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":LSUpdate");
            }
            return num3;
        }

        public uint VLS_RELEASE(int handle)
        {
            uint num3;
            uint errorCode = 0;
            uint unitsReqd = 1;
            try
            {
                errorCode = LSAPI.LSRelease(handle, unitsReqd, "");
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num3 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLS_RELEASE");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLS_RELEASE");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLS_RELEASE");
            }
            return num3;
        }

        public uint VLS_REQUEST(string feature, string version, ref int handle)
        {
            uint num3;
            uint errorCode = 0;
            string licenseSystem = "SafeNet-Inc";
            string publisherName = "RMSSystem";
            uint unitsReqd = 1;
            CHALLENGE challenge = new CHALLENGE();
            try
            {
                errorCode = LSAPI.LSRequest(licenseSystem, publisherName, feature, version, ref unitsReqd, "", ref challenge, ref handle);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num3 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLS_REQUEST");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLS_REQUEST");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLS_REQUEST");
            }
            return num3;
        }

        public uint VLS_UPDATE(int handle)
        {
            uint num3;
            uint errorCode = 0;
            int num2 = 1;
            CHALLENGE challenge = new CHALLENGE();
            try
            {
                errorCode = LSAPI.LSUpdate(handle, 0, ref num2, "", ref challenge);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num3 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLS_UPDATE");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLS_UPDATE");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLS_UPDATE");
            }
            return num3;
        }

        public uint VLSaddFeature(string license_string)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                CHALLENGE challenge = new CHALLENGE();
                errorCode = LSAPI.VLSaddFeature(license_string, null, ref challenge);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSaddFeature");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSaddFeature");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSaddFeature");
            }
            return num2;
        }

        public uint VLSaddFeatureExt(string licenseString, string DistCritString, string log_comment, ref object challenge)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                CHALLENGE challenge2 = new CHALLENGE();
                if (challenge != null)
                {
                    challenge2 = (CHALLENGE)challenge;
                }
                errorCode = LSAPI.VLSaddFeatureExt(licenseString, DistCritString, log_comment, ref challenge2);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                if (challenge != null)
                {
                    challenge = challenge2;
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSaddFeatureExt");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSaddFeatureExt");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSaddFeatureExt");
            }
            return num2;
        }

        public uint VLSaddFeatureToFile(string license_string)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                CHALLENGE challenge = new CHALLENGE();
                errorCode = LSAPI.VLSaddFeatureToFile(license_string, null, null, ref challenge);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSaddFeatureToFile");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSaddFeatureToFile");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSaddFeatureToFile");
            }
            return num2;
        }

        public uint VLSaddFeatureToFileExt(string licenseString, string DistCritString, string license_file_name, string log_comment, ref object challenge)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                CHALLENGE challenge2 = new CHALLENGE();
                if (challenge != null)
                {
                    challenge2 = (CHALLENGE)challenge;
                }
                errorCode = LSAPI.VLSaddFeatureToFileExt(licenseString, DistCritString, license_file_name, log_comment, ref challenge2);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                if (challenge != null)
                {
                    challenge = challenge2;
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSaddFeatureToFileExt");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSaddFeatureToFileExt");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSaddFeatureToFileExt");
            }
            return num2;
        }

        public uint VLSaddServerToPool(string server_name, string server_addr)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSaddServerToPool(server_name, server_addr);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSaddServerToPool");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSaddServerToPool");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSaddServerToPool");
            }
            return num2;
        }

        public uint VLSbatchUpdate(int numHandles, int[] lshandle, int[] status)
        {
            int[] numArray = null;
            uint num5;
            uint errorCode = 0;
            uint num2 = 0;
            int num3 = 0;
            CHALLENGE challenge = new CHALLENGE();
            try
            {
                if (numHandles != 0)
                {
                    numArray = new int[numHandles];
                    for (int i = 0; i < numHandles; i++)
                    {
                        numArray[i] = lshandle[i];
                    }
                }
                else
                {
                    errorCode = 0xc800100b;
                    throw new Wechoid.Exception.CoreException(0xc800100b, this.GetErrorMsgString(0xc800100b));
                }
                errorCode = LSAPI.VLSbatchUpdate(numHandles, lshandle, ref num2, ref num3, null, ref challenge, status);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num5 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSbatchUpdate");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSbatchUpdate");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSbatchUpdate");
            }
            return num5;
        }

        public uint VLScalculateLicenseHash(string pcLicenseString, StringBuilder pucLicenseHash, ref int piLicenseHashLength)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLScalculateLicenseHash(pcLicenseString, pucLicenseHash, ref piLicenseHashLength);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLScalculateLicenseHash");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLScalculateLicenseHash");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLScalculateLicenseHash");
            }
            return num2;
        }

        public uint VLSchangeDistbCrit(string feature_name, string feature_version, string dist_crit)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSchangeDistbCrit(feature_name, feature_version, dist_crit);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSchangeDistbCrit");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSchangeDistbCrit");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSchangeDistbCrit");
            }
            return num2;
        }

        public uint VLSchangeUsageLogFileName(string hostname, string newFileName)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSchangeUsageLogFileName(hostname, newFileName);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSchangeUsageLogFileName");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSchangeUsageLogFileName");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSchangeUsageLogFileName");
            }
            return num2;
        }

        public uint VLScleanExpiredCommuterCode(string feature_name, string feature_version)
        {
            uint num3;
            uint errorCode = 0;
            try
            {
                int unused = 0;
                errorCode = LSAPI.VLScleanExpiredCommuterCode(feature_name, feature_version, null, ref unused);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num3 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLScleanExpiredCommuterCode");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLScleanExpiredCommuterCode");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLScleanExpiredCommuterCode");
            }
            return num3;
        }

        public uint VLScleanup()
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLScleanup();
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLScleanup");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLScleanup");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLScleanup");
            }
            return num2;
        }

        public uint VLScompareB(object challenge, object challengeResponse, string secret)
        {
            uint num2;
            if (challenge == null)
            {
                throw new Wechoid.Exception.CoreException(500, "Error[500]: API called with null value for parameter challenge:VLScompareB");
            }
            if (challengeResponse == null)
            {
                throw new Wechoid.Exception.CoreException(500, "Error[500]: API called with null value for parameter challengeResponse:VLScompareB");
            }
            uint errorCode = 0;
            try
            {
                CHALLENGE challenge2 = new CHALLENGE();
                CHALLENGE challenge3 = new CHALLENGE();
                challenge2 = (CHALLENGE)challenge;
                challenge3 = (CHALLENGE)challengeResponse;
                errorCode = LSAPI.VLScompareB(ref challenge2, ref challenge3, secret);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, "Response is not correct");
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLScompareB");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLScompareB");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLScompareB");
            }
            return num2;
        }

        public uint VLScontrolRemoteSession(int toCheckRemoteSession)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLScontrolRemoteSession(toCheckRemoteSession);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLScontrolRemoteSession");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLScontrolRemoteSession");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLScontrolRemoteSession");
            }
            return num2;
        }

        public uint VLSdeleteFeature(string feature_name, string version)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                CHALLENGE challenge = new CHALLENGE();
                errorCode = LSAPI.VLSdeleteFeature(feature_name, version, null, ref challenge);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSdeleteFeature");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSdeleteFeature");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSdeleteFeature");
            }
            return num2;
        }

        public uint VLSdeleteFeatureExt(string feature_name, string version, object capacity, string log_comment, ref object challenge)
        {
            uint num3;
            uint errorCode = 0;
            try
            {
                uint num2 = 0;
                CHALLENGE challenge2 = new CHALLENGE();
                errorCode = LSAPI.VLSdeleteFeatureExt(feature_name, version, capacity, null, ref challenge2, null, ref num2);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num3 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSdeleteFeatureExt");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSdeleteFeatureExt");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSdeleteFeatureExt");
            }
            return num3;
        }

        public uint VLSdeleteLicenseFromFile(string feature_name, string version, string license_hash, int license_hash_len, StringBuilder license_string, ref int license_string_bufsize)
        {
            uint num4;
            if (license_string == null)
            {
                throw new Wechoid.Exception.CoreException(500, "Error[500]: API called with null value for parameter license_string:VLSdeleteLicenseFromFile");
            }
            uint errorCode = 0;
            try
            {
                int num2 = 0;
                uint num3 = (uint)license_string_bufsize;
                errorCode = LSAPI.VLSdeleteLicenseFromFile(feature_name, version, license_hash, license_hash_len, license_string, ref num3, ref num2, num2);
                license_string_bufsize = (int)num3;
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num4 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSdeleteLicenseFromFile");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSdeleteLicenseFromFile");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSdeleteLicenseFromFile");
            }
            return num4;
        }

        public uint VLSdeleteLicenseFromFileExt(string feature_name, string version, object puiCapacity, string license_hash, int license_hash_len, StringBuilder license_string, ref int license_string_bufsize)
        {
            uint num3;
            if (license_string == null)
            {
                throw new Wechoid.Exception.CoreException(500, "Error[500]: API called with null value for parameter license_string:VLSdeleteLicenseFromFileExt");
            }
            uint errorCode = 0;
            try
            {
                int num2 = 0;
                errorCode = LSAPI.VLSdeleteLicenseFromFileExt(feature_name, version, puiCapacity, license_hash, license_hash_len, license_string, ref license_string_bufsize, ref num2, num2);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num3 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSdeleteLicenseFromFileExt");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSdeleteLicenseFromFileExt");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSdeleteLicenseFromFileExt");
            }
            return num3;
        }

        public uint VLSdelServerFromPool(string server_name, string server_addr)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSdelServerFromPool(server_name, server_addr);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSdelServerFromPool");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSdelServerFromPool");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSdelServerFromPool");
            }
            return num2;
        }

        public uint VLSdestroyHandleInClient(int lshandle)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSdestroyHandleInClient(lshandle);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSdestroyHandleInClient");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSdestroyHandleInClient");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSdestroyHandleInClient");
            }
            return num2;
        }

        public uint VLSdisableAutoTimer(int handle, int state)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSdisableAutoTimer(handle, state);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSdisableAutoTimer");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSdisableAutoTimer");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSdisableAutoTimer");
            }
            return num2;
        }

        public uint VLSdisableLicense(ref int handle)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSdisableLicense(ref handle);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSdisableLicense");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSdisableLicense");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSdisableLicense");
            }
            return num2;
        }

        public uint VLSdisableLocalRenewal()
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSdisableLocalRenewal();
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSdisableLocalRenewal");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSdisableLocalRenewal");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSdisableLocalRenewal");
            }
            return num2;
        }

        public uint VLSdiscover(string feature_name, string version, int bufferSize, StringBuilder server_names, int broadcastFlag, string vendor_list)
        {
            uint num2;
            if (server_names == null)
            {
                throw new Wechoid.Exception.CoreException(500, "Error[500]: API called with null value for parameter server_names:VLSdiscover");
            }
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSdiscover(feature_name, version, null, bufferSize, server_names, broadcastFlag, vendor_list);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSdiscover");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSdiscover");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSdiscover");
            }
            return num2;
        }

        public uint VLSdiscoverExt(string feature_name, string version, ref int num_servers, ref VLSdiscoverInfo[] discoverInfo, int optionFlag, int sharing_crit, StringBuilder vendor_list)
        {
            uint num3;
            uint errorCode = 0;
            try
            {
                VLSdiscoverInfo[] infoArray = new VLSdiscoverInfo[num_servers];
                for (int i = 0; i < num_servers; i++)
                {
                    infoArray[i] = new VLSdiscoverInfo();
                }
                errorCode = LSAPI.VLSdiscoverExt(feature_name, version, null, ref num_servers, ref infoArray, optionFlag, sharing_crit, vendor_list);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num3 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSdiscoverExt");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSdiscoverExt");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSdiscoverExt");
            }
            return num3;
        }

        public uint VLSenableLocalRenewal()
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSenableLocalRenewal();
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSenableLocalRenewal");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSenableLocalRenewal");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSenableLocalRenewal");
            }
            return num2;
        }

        public uint VLSerrorHandle(int errorHandle)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSerrorHandle(errorHandle);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSerrorHandle");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSerrorHandle");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSerrorHandle");
            }
            return num2;
        }

        public uint VLSgetActiveHandleList(ref int[] outHandleBuf, ref uint numHandle)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                outHandleBuf = new int[numHandle];
                errorCode = LSAPI.VLSgetActiveHandleList(ref outHandleBuf, ref numHandle);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetActiveHandleList");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetActiveHandleList");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetActiveHandleList");
            }
            return num2;
        }

        public uint VLSgetAndInstallCommuterCode(string feature_name, string feature_version, ref uint units_reqd, ref int duration, ref int lock_mask, string log_comment, ref object challenge)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                CHALLENGE challenge2 = new CHALLENGE();
                if (challenge != null)
                {
                    challenge2 = (CHALLENGE)challenge;
                }
                errorCode = LSAPI.VLSgetAndInstallCommuterCode(feature_name, feature_version, ref units_reqd, ref duration, ref lock_mask, log_comment, ref challenge2);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                challenge = challenge2;
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetAndInstallCommuterCode");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetAndInstallCommuterCode");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetAndInstallCommuterCode");
            }
            return num2;
        }

        public uint VLSgetBroadcastInterval()
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = (uint)LSAPI.VLSgetBroadcastInterval();
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetBroadcastInterval");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetBroadcastInterval");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetBroadcastInterval");
            }
            return num2;
        }

        public uint VLSgetCapacityFromHandle(int lshandle, ref uint user_capacity, ref uint team_capacity, ref uint license_capacity)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSgetCapacityFromHandle(lshandle, ref user_capacity, ref team_capacity, ref license_capacity);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetCapacityFromHandle");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetCapacityFromHandle");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetCapacityFromHandle");
            }
            return num2;
        }

        public uint VLSgetCapacityList(string feature_name, string feature_version, ref int index, ref int bufferSize, StringBuilder capacityList)
        {
            uint num3;
            if (capacityList == null)
            {
                throw new Wechoid.Exception.CoreException(500, "Error[500]: API called with null value for parameter capacityList:VLSgetCapacityList");
            }
            uint errorCode = 0;
            try
            {
                uint num2 = 0;
                errorCode = LSAPI.VLSgetCapacityList(feature_name, feature_version, ref index, ref bufferSize, capacityList, null, ref num2);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num3 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetCapacityList");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetCapacityList");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetCapacityList");
            }
            return num3;
        }

        public uint VLSgetClientInfo(string feature_name, string version, ref VLSClientInfo[] vlsClientInfoArray)
        {
            VLSClientInfo info = new VLSClientInfo();
            uint num4;
            ArrayList list = new ArrayList();
            bool flag = false;
            uint errorCode = 0;
            int index = 0;
            info = new VLSClientInfo
            {
                structSz = Marshal.SizeOf(info)
            };
            int newSize = 0;
            try
            {
                do
                {
                    errorCode = LSAPI.VLSgetClientInfo(feature_name, version, index, null, ref info);
                    switch (errorCode)
                    {
                        case 0:
                            list.Add(info);
                            break;

                        case 9:
                            flag = true;
                            break;
                    }
                    index++;
                }
                while (!flag && (errorCode == 0));
                newSize = list.Count;
                Array.Resize<VLSClientInfo>(ref vlsClientInfoArray, newSize);
                vlsClientInfoArray = (VLSClientInfo[])list.ToArray(typeof(VLSClientInfo));
                if ((errorCode == 9) && (newSize != 0))
                {
                    errorCode = 0;
                }
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num4 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetClientInfo");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetClientInfo");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetClientInfo");
            }
            return num4;
        }

        public uint VLSgetClientInfo(string feature_name, string version, int index, ref VLSClientInfo client_info)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSgetClientInfo(feature_name, version, index, null, ref client_info);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetClientInfo");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetClientInfo");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetClientInfo");
            }
            return num2;
        }

        public uint VLSgetClientInfoExt(string feature_name, string version, object Capcity, ref VLSClientInfo[] vlsClientInfoArray)
        {
            VLSClientInfo info = new VLSClientInfo();
            uint num5;
            ArrayList list = new ArrayList();
            bool flag = false;
            uint errorCode = 0;
            int index = 0;
            info = new VLSClientInfo
            {
                structSz = Marshal.SizeOf(info)
            };
            int newSize = 0;
            uint num4 = 0;
            try
            {
                do
                {
                    errorCode = LSAPI.VLSgetClientInfoExt(feature_name, version, Capcity, index, null, ref num4, ref info);
                    switch (errorCode)
                    {
                        case 0:
                            list.Add(info);
                            break;

                        case 9:
                            flag = true;
                            break;
                    }
                    index++;
                }
                while (!flag && (errorCode == 0));
                newSize = list.Count;
                Array.Resize<VLSClientInfo>(ref vlsClientInfoArray, newSize);
                vlsClientInfoArray = (VLSClientInfo[])list.ToArray(typeof(VLSClientInfo));
                if ((errorCode == 9) && (newSize != 0))
                {
                    errorCode = 0;
                }
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num5 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetClientInfoExt");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetClientInfoExt");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetClientInfoExt");
            }
            return num5;
        }

        public uint VLSgetClientInfoExt(string feature_name, string version, object capacity, int index, string log_comment, ref VLSClientInfo client_info)
        {
            uint num3;
            uint errorCode = 0;
            try
            {
                uint num2 = 0;
                errorCode = LSAPI.VLSgetClientInfoExt(feature_name, version, capacity, index, log_comment, ref num2, ref client_info);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num3 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetClientInfoExt");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetClientInfoExt");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetClientInfoExt");
            }
            return num3;
        }

        public uint VLSgetCommuterCode(string feature_name, string feature_version, ref uint units_reqd, ref int duration, ref uint lock_mask, string log_comment, string machineIDString, StringBuilder commuter_code, ref object challenge, object ExtensionInDuration)
        {
            uint num3;
            if (commuter_code == null)
            {
                throw new Wechoid.Exception.CoreException(500, "Error[500]: API called with null value for parameter commuter_code:VLSgetCommuterCode");
            }
            uint errorCode = 0;
            try
            {
                int num2 = (int)units_reqd;
                VLSserverInfo requestInfo = new VLSserverInfo();
                CHALLENGE challenge2 = new CHALLENGE();
                if (challenge != null)
                {
                    challenge2 = (CHALLENGE)challenge;
                }
                errorCode = LSAPI.VLSgetCommuterCode(feature_name, feature_version, ref num2, ref duration, ref lock_mask, log_comment, machineIDString, commuter_code, ref challenge2, ref requestInfo, ref requestInfo, ExtensionInDuration);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                if (challenge != null)
                {
                    challenge = challenge2;
                }
                num3 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetCommuterCode");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetCommuterCode");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetCommuterCode");
            }
            return num3;
        }

        public uint VLSgetCommuterInfo(ref VLScommuterInfo[] vLScommuterInfoArray)
        {
            uint num4;
            ArrayList list = new ArrayList();
            bool flag = false;
            uint errorCode = 0;
            int index = 1;
            VLScommuterInfo info = new VLScommuterInfo();
            int newSize = 0;
            try
            {
                do
                {
                    errorCode = LSAPI.VLSgetCommuterInfo(null, null, index, ref info);
                    switch (errorCode)
                    {
                        case 0:
                            list.Add(info);
                            break;

                        case 0x48:
                            flag = true;
                            break;

                        case 0x53:
                            errorCode = 0;
                            list.Add(info);
                            break;
                    }
                    index++;
                }
                while (!flag && (errorCode == 0));
                newSize = list.Count;
                Array.Resize<VLScommuterInfo>(ref vLScommuterInfoArray, newSize);
                vLScommuterInfoArray = (VLScommuterInfo[])list.ToArray(typeof(VLScommuterInfo));
                if ((errorCode == 0x48) && (newSize != 0))
                {
                    errorCode = 0;
                }
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num4 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetCommuterInfo");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetCommuterInfo");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetCommuterInfo");
            }
            return num4;
        }

        public uint VLSgetCommuterInfo(string feature_name, string feature_version, int index, ref VLScommuterInfo commuter_info)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSgetCommuterInfo(feature_name, feature_version, index, ref commuter_info);
                if ((errorCode != 0) && (errorCode != 0x53))
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetCommuterInfo");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetCommuterInfo");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetCommuterInfo");
            }
            return num2;
        }

        public uint VLSgetConsumeLimit(int iHandle, Wechoid.Const.Const.CONSUME_LIMIT_TYPE consume_type, ref int consume_value)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                CHALLENGE challenge = new CHALLENGE();
                errorCode = LSAPI.VLSgetConsumeLimit(iHandle, consume_type, ref consume_value, ref challenge);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetConsumeLimit");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetConsumeLimit");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetConsumeLimit");
            }
            return num2;
        }

        public uint VLSgetContactServer(ref StringBuilder outBuf)
        {
            uint num3;
            if (outBuf == null)
            {
                throw new Wechoid.Exception.CoreException(500, "Error[500]: API called with null value for parameter outBuf:VLSgetContactServer");
            }
            uint errorCode = 0;
            try
            {
                outBuf = new StringBuilder(0x80);
                int outBufSz = 0x80;
                errorCode = LSAPI.VLSgetContactServer(outBuf, outBufSz);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num3 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetContactServer");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetContactServer");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetContactServer");
            }
            return num3;
        }

        public uint VLSgetContextData(int iHandle, StringBuilder context_buff, uint buff_len)
        {
            uint num2;
            if (context_buff == null)
            {
                throw new Wechoid.Exception.CoreException(500, "Error[500]: API called with null value for parameter context_buff:VLSgetContextData");
            }
            uint errorCode = 0;
            try
            {
                CHALLENGE challenge = new CHALLENGE();
                errorCode = LSAPI.VLSgetContextData(iHandle, context_buff, buff_len, ref challenge);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetContextData");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetContextData");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetContextData");
            }
            return num2;
        }

        public uint VLSgetDistbCrit(string feature_name, string feature_version, StringBuilder dist_crit, int distcrit_buflen)
        {
            uint num2;
            if (dist_crit == null)
            {
                throw new Wechoid.Exception.CoreException(500, "Error[500]: API called with null value for parameter dist_crit:VLSgetDistbCrit");
            }
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSgetDistbCrit(feature_name, feature_version, dist_crit, distcrit_buflen);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetDistbCrit");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetDistbCrit");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetDistbCrit");
            }
            return num2;
        }

        public uint VLSgetDistbCritToFile(string feature_name, string feature_version, string file_name)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSgetDistbCritToFile(feature_name, feature_version, file_name);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetDistbCritToFile");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetDistbCritToFile");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetDistbCritToFile");
            }
            return num2;
        }

        public uint VLSgetFeatureFromHandle(int handle, ref StringBuilder Buffer)
        {
            uint num2;
            if (Buffer == null)
            {
                throw new Wechoid.Exception.CoreException(500, "Error[500]: API called with null value for parameter Buffer:VLSgetFeatureFromHandle");
            }
            uint errorCode = 0;
            StringBuilder buffer = new StringBuilder(0x40);
            try
            {
                errorCode = LSAPI.VLSgetFeatureFromHandle(handle, buffer, 0x40);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                Buffer = buffer;
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetFeatureFromHandle");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetFeatureFromHandle");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetFeatureFromHandle");
            }
            return num2;
        }

        public uint VLSgetFeatureInfo(ref VLSFeatureInfo[] vlsFeatureInfoArray)
        {
            VLSFeatureInfo info = new VLSFeatureInfo();
            uint num4;
            ArrayList list = new ArrayList();
            bool flag = false;
            uint errorCode = 0;
            int index = 0;
            info = new VLSFeatureInfo
            {
                structSz = Marshal.SizeOf(info)
            };
            int newSize = 0;
            try
            {
                do
                {
                    errorCode = LSAPI.VLSgetFeatureInfo(null, null, index, null, ref info);
                    switch (errorCode)
                    {
                        case 0:
                            list.Add(info);
                            break;

                        case 10:
                            flag = true;
                            break;
                    }
                    index++;
                }
                while (!flag && (errorCode == 0));
                newSize = list.Count;
                Array.Resize<VLSFeatureInfo>(ref vlsFeatureInfoArray, newSize);
                vlsFeatureInfoArray = (VLSFeatureInfo[])list.ToArray(typeof(VLSFeatureInfo));
                if ((errorCode == 10) && (newSize != 0))
                {
                    errorCode = 0;
                }
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num4 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetFeatureInfo");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetFeatureInfo");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetFeatureInfo");
            }
            return num4;
        }

        public uint VLSgetFeatureInfo(string feature_name, string version, int index, ref VLSFeatureInfo feature_info)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSgetFeatureInfo(feature_name, version, index, null, ref feature_info);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetFeatureInfo");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetFeatureInfo");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetFeatureInfo");
            }
            return num2;
        }

        public uint VLSgetFeatureInfoExt(ref VLSFeatureInfo[] vlsFeatureInfoArray)
        {
            VLSFeatureInfo info = new VLSFeatureInfo();
            uint num5;
            ArrayList list = new ArrayList();
            bool flag = false;
            uint errorCode = 0;
            uint num2 = 0;
            int index = 0;
            info = new VLSFeatureInfo
            {
                structSz = Marshal.SizeOf(info)
            };
            int newSize = 0;
            try
            {
                do
                {
                    errorCode = LSAPI.VLSgetFeatureInfoExt(null, null, null, index, null, ref num2, ref info);
                    switch (errorCode)
                    {
                        case 0:
                            list.Add(info);
                            break;

                        case 10:
                            flag = true;
                            break;
                    }
                    index++;
                }
                while (!flag && (errorCode == 0));
                newSize = list.Count;
                Array.Resize<VLSFeatureInfo>(ref vlsFeatureInfoArray, newSize);
                vlsFeatureInfoArray = (VLSFeatureInfo[])list.ToArray(typeof(VLSFeatureInfo));
                if ((errorCode == 10) && (newSize != 0))
                {
                    errorCode = 0;
                }
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num5 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetFeatureInfoExt");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetFeatureInfoExt");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetFeatureInfoExt");
            }
            return num5;
        }

        public uint VLSgetFeatureInfoExt(string feature_name, string version, object capacity, int index, ref VLSFeatureInfo feature_info)
        {
            uint num3;
            uint errorCode = 0;
            try
            {
                uint num2 = 0;
                errorCode = LSAPI.VLSgetFeatureInfoExt(feature_name, version, capacity, index, null, ref num2, ref feature_info);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num3 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetFeatureInfoExt");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetFeatureInfoExt");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetFeatureInfoExt");
            }
            return num3;
        }

        public uint VLSgetFeatureTimeLeftFromHandle(int lshandle, ref uint secondsUntilTheFeatureExpires)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSgetFeatureTimeLeftFromHandle(lshandle, ref secondsUntilTheFeatureExpires);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetFeatureTimeLeftFromHandle");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetFeatureTimeLeftFromHandle");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetFeatureTimeLeftFromHandle");
            }
            return num2;
        }

        public uint VLSgetGraceRequestFlag()
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSgetGraceRequestFlag();
                if ((errorCode != 0) && (errorCode != 1))
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetGraceRequestFlag");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetGraceRequestFlag");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetGraceRequestFlag");
            }
            return num2;
        }

        public uint VLSgetHandleInfo(int lshandle, ref VLSClientInfo client_info)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSgetHandleInfo(lshandle, ref client_info);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetHandleInfo");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetHandleInfo");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetHandleInfo");
            }
            return num2;
        }

        public uint VLSgetHandleStatus(int lshandle)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSgetHandleStatus(lshandle);
                if (((errorCode != 0) && (errorCode != 40)) && (errorCode != 0x29))
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetHandleStatus");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetHandleStatus");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetHandleStatus");
            }
            return num2;
        }

        public uint VLSgetKeyTimeLeftFromHandle(int lshandle, ref uint secondsUntilTheKeyExpires)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSgetKeyTimeLeftFromHandle(lshandle, ref secondsUntilTheKeyExpires);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetKeyTimeLeftFromHandle");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetKeyTimeLeftFromHandle");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetKeyTimeLeftFromHandle");
            }
            return num2;
        }

        public uint VLSgetLastErrorStatusFromHandle(int lshandle, ref int status_code)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSgetLastErrorStatusFromHandle(lshandle, ref status_code);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetLastErrorStatusFromHandle");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetLastErrorStatusFromHandle");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetLastErrorStatusFromHandle");
            }
            return num2;
        }

        public uint VLSgetLeaderServerName(ref StringBuilder leader_name)
        {
            uint num3;
            if (leader_name == null)
            {
                throw new Wechoid.Exception.CoreException(500, "Error[500]: API called with null value for parameter leader_name:VLSgetLeaderServerName");
            }
            uint errorCode = 0;
            try
            {
                StringBuilder builder = new StringBuilder(30);
                int num2 = 30;
                errorCode = LSAPI.VLSgetLeaderServerName(builder, num2);
                if (errorCode == 0)
                {
                    leader_name = builder;
                }
                if (((errorCode != 0) && (errorCode != 1)) && (errorCode != 2))
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num3 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetLeaderServerName");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetLeaderServerName");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetLeaderServerName");
            }
            return num3;
        }

        public uint VLSgetLibInfo(ref LS_LIBVERSION pInfo)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSgetLibInfo(ref pInfo);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetLibInfo");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetLibInfo");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetLibInfo");
            }
            return num2;
        }

        public uint VLSgetLicenseInfo(ref VLSlicenseInfo[] vlsLicenseInfoArray)
        {
            VLSlicenseInfo info = new VLSlicenseInfo();
            uint num5;
            uint errorCode = 0;
            ArrayList list = new ArrayList();
            bool flag = false;
            bool flag2 = false;
            info = new VLSlicenseInfo
            {
                structSz = Marshal.SizeOf(info)
            };
            int num2 = 0;
            int num3 = 0;
            int newSize = 0;
            try
            {
                do
                {
                    flag = false;
                    do
                    {
                        errorCode = LSAPI.VLSgetLicenseInfo(null, null, num2, "", 20, num3, ref info);
                        switch (errorCode)
                        {
                            case 0:
                                list.Add(info);
                                break;

                            case 10:
                                flag = true;
                                flag2 = true;
                                break;

                            case 0x8b:
                                errorCode = 0;
                                flag = true;
                                break;
                        }
                        num3++;
                    }
                    while (!flag && (errorCode == 0));
                    num2++;
                    num3 = 0;
                }
                while (!flag2 && (errorCode == 0));
                newSize = list.Count;
                Array.Resize<VLSlicenseInfo>(ref vlsLicenseInfoArray, newSize);
                vlsLicenseInfoArray = (VLSlicenseInfo[])list.ToArray(typeof(VLSlicenseInfo));
                if ((errorCode == 10) && (newSize != 0))
                {
                    errorCode = 0;
                }
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num5 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetLicenseInfo");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetLicenseInfo");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetLicenseInfo");
            }
            return num5;
        }

        public uint VLSgetLicenseInfo(int indexValue, ref VLSlicenseInfo[] vlsLicenseInfoArray, char IndexType)
        {
            VLSlicenseInfo info = new VLSlicenseInfo();
            uint num5;
            uint errorCode = 0;
            ArrayList list = new ArrayList();
            info = new VLSlicenseInfo
            {
                structSz = Marshal.SizeOf(info)
            };
            int num2 = 0;
            int num3 = 0;
            bool flag = false;
            bool flag2 = false;
            bool flag3 = false;
            int newSize = 0;
            try
            {
                if ((!IndexType.Equals('L') && !IndexType.Equals('F')) && (!IndexType.Equals('l') && !IndexType.Equals('f')))
                {
                    return 11;
                }
                if (IndexType.Equals('L') || IndexType.Equals('l'))
                {
                    flag3 = true;
                    num3 = indexValue;
                }
                else if (IndexType.Equals('F') || IndexType.Equals('f'))
                {
                    flag2 = true;
                    num2 = indexValue;
                }
                do
                {
                    errorCode = LSAPI.VLSgetLicenseInfo(null, null, num2, "", 20, num3, ref info);
                    switch (errorCode)
                    {
                        case 0:
                            list.Add(info);
                            break;

                        case 10:
                            if (flag3)
                            {
                                flag = true;
                            }
                            break;

                        case 0x8b:
                            if (flag2)
                            {
                                flag = true;
                            }
                            if (flag3)
                            {
                                errorCode = 0;
                            }
                            break;
                    }
                    if (flag3)
                    {
                        num2++;
                    }
                    if (flag2)
                    {
                        num3++;
                    }
                }
                while (!flag && (errorCode == 0));
                newSize = list.Count;
                Array.Resize<VLSlicenseInfo>(ref vlsLicenseInfoArray, newSize);
                vlsLicenseInfoArray = (VLSlicenseInfo[])list.ToArray(typeof(VLSlicenseInfo));
                if (((errorCode == 10) && (newSize != 0)) && (IndexType.Equals('L') || IndexType.Equals('l')))
                {
                    errorCode = 0;
                }
                if (((errorCode == 0x8b) && (newSize != 0)) && (IndexType.Equals('F') || IndexType.Equals('f')))
                {
                    errorCode = 0;
                }
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num5 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetLicenseInfo");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetLicenseInfo");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetLicenseInfo");
            }
            return num5;
        }

        public uint VLSgetLicenseInfo(string featureName, string version, ref VLSlicenseInfo[] vlsLicenseInfoArray)
        {
            VLSlicenseInfo info = new VLSlicenseInfo();
            uint num4;
            uint errorCode = 0;
            ArrayList list = new ArrayList();
            info = new VLSlicenseInfo
            {
                structSz = Marshal.SizeOf(info)
            };
            int num2 = 0;
            bool flag = false;
            int newSize = 0;
            try
            {
                do
                {
                    errorCode = LSAPI.VLSgetLicenseInfo(featureName, version, 0, "", 20, num2, ref info);
                    switch (errorCode)
                    {
                        case 0:
                            list.Add(info);
                            break;

                        case 0x8b:
                            flag = true;
                            break;
                    }
                    num2++;
                }
                while (!flag && (errorCode == 0));
                newSize = list.Count;
                Array.Resize<VLSlicenseInfo>(ref vlsLicenseInfoArray, newSize);
                vlsLicenseInfoArray = (VLSlicenseInfo[])list.ToArray(typeof(VLSlicenseInfo));
                if ((errorCode == 0x8b) && (newSize != 0))
                {
                    errorCode = 0;
                }
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num4 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetLicenseInfo");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetLicenseInfo");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetLicenseInfo");
            }
            return num4;
        }

        public uint VLSgetLicenseInfo(string feature_name, string version, int feature_index, string license_hash, int license_hash_len, int license_index, ref VLSlicenseInfo licenseInfo)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                if (license_hash != null)
                {
                    license_hash = license_hash.ToUpper();
                }
                errorCode = LSAPI.VLSgetLicenseInfo(feature_name, version, feature_index, license_hash, license_hash_len, license_index, ref licenseInfo);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetLicenseInfo");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetLicenseInfo");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetLicenseInfo");
            }
            return num2;
        }

        public uint VLSgetLicenseInfoExt(ref VLSlicenseInfo[] vlsLicenseInfoArray)
        {
            VLSlicenseInfo info = new VLSlicenseInfo();
            uint num5;
            uint errorCode = 0;
            ArrayList list = new ArrayList();
            bool flag = false;
            bool flag2 = false;
            info = new VLSlicenseInfo
            {
                structSz = Marshal.SizeOf(info)
            };
            int num2 = 0;
            int num3 = 0;
            int newSize = 0;
            try
            {
                do
                {
                    flag = false;
                    do
                    {
                        errorCode = LSAPI.VLSgetLicenseInfoExt(null, null, null, num2, "", 20, num3, ref info);
                        switch (errorCode)
                        {
                            case 0:
                                list.Add(info);
                                break;

                            case 10:
                                flag = true;
                                flag2 = true;
                                break;

                            case 0x8b:
                                errorCode = 0;
                                flag = true;
                                break;
                        }
                        num3++;
                    }
                    while (!flag && (errorCode == 0));
                    num2++;
                    num3 = 0;
                }
                while (!flag2 && (errorCode == 0));
                newSize = list.Count;
                Array.Resize<VLSlicenseInfo>(ref vlsLicenseInfoArray, newSize);
                vlsLicenseInfoArray = (VLSlicenseInfo[])list.ToArray(typeof(VLSlicenseInfo));
                if ((errorCode == 10) && (newSize != 0))
                {
                    errorCode = 0;
                }
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num5 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetLicenseInfoExt");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetLicenseInfoExt");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetLicenseInfoExt");
            }
            return num5;
        }

        public uint VLSgetLicenseInfoExt(int indexValue, ref VLSlicenseInfo[] vlsLicenseInfoArray, char IndexType)
        {
            VLSlicenseInfo info = new VLSlicenseInfo();
            uint num5;
            uint errorCode = 0;
            ArrayList list = new ArrayList();
            info = new VLSlicenseInfo
            {
                structSz = Marshal.SizeOf(info)
            };
            int num2 = 0;
            int num3 = 0;
            bool flag = false;
            bool flag2 = false;
            bool flag3 = false;
            int newSize = 0;
            try
            {
                if ((!IndexType.Equals('L') && !IndexType.Equals('F')) && (!IndexType.Equals('l') && !IndexType.Equals('f')))
                {
                    return 11;
                }
                if (IndexType.Equals('L') || IndexType.Equals('l'))
                {
                    flag3 = true;
                    num3 = indexValue;
                }
                else if (IndexType.Equals('F') || IndexType.Equals('f'))
                {
                    flag2 = true;
                    num2 = indexValue;
                }
                do
                {
                    errorCode = LSAPI.VLSgetLicenseInfoExt(null, null, null, num2, "", 20, num3, ref info);
                    switch (errorCode)
                    {
                        case 0:
                            list.Add(info);
                            break;

                        case 0x8b:
                            if (flag3)
                            {
                                errorCode = 0;
                            }
                            break;
                    }
                    if (flag3)
                    {
                        num2++;
                    }
                    if (flag2)
                    {
                        num3++;
                    }
                }
                while (!flag && (errorCode == 0));
                newSize = list.Count;
                Array.Resize<VLSlicenseInfo>(ref vlsLicenseInfoArray, newSize);
                vlsLicenseInfoArray = (VLSlicenseInfo[])list.ToArray(typeof(VLSlicenseInfo));
                if (((errorCode == 10) && (newSize != 0)) && (IndexType.Equals('L') || IndexType.Equals('L')))
                {
                    errorCode = 0;
                }
                if (((errorCode == 0x8b) && (newSize != 0)) && (IndexType.Equals('F') || IndexType.Equals('f')))
                {
                    errorCode = 0;
                }
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num5 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetLicenseInfoExt");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetLicenseInfoExt");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetLicenseInfoExt");
            }
            return num5;
        }

        public uint VLSgetLicenseInfoExt(string featureName, string version, object capacity, ref VLSlicenseInfo[] vlsLicenseInfoArray)
        {
            VLSlicenseInfo info = new VLSlicenseInfo();
            uint num4;
            uint errorCode = 0;
            ArrayList list = new ArrayList();
            info = new VLSlicenseInfo
            {
                structSz = Marshal.SizeOf(info)
            };
            int num2 = 0;
            bool flag = false;
            int newSize = 0;
            try
            {
                do
                {
                    errorCode = LSAPI.VLSgetLicenseInfoExt(featureName, version, capacity, 0, "", 20, num2, ref info);
                    switch (errorCode)
                    {
                        case 0:
                            list.Add(info);
                            break;

                        case 0x8b:
                            flag = true;
                            break;
                    }
                    num2++;
                }
                while (!flag && (errorCode == 0));
                newSize = list.Count;
                Array.Resize<VLSlicenseInfo>(ref vlsLicenseInfoArray, newSize);
                vlsLicenseInfoArray = (VLSlicenseInfo[])list.ToArray(typeof(VLSlicenseInfo));
                if ((errorCode == 0x8b) && (newSize != 0))
                {
                    errorCode = 0;
                }
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num4 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetLicenseInfoExt");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetLicenseInfoExt");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetLicenseInfoExt");
            }
            return num4;
        }

        public uint VLSgetLicenseInfoExt(string feature_name, string version, object capacity, int feature_index, string license_hash, int license_hash_len, int license_index, ref VLSlicenseInfo licenseInfo)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                if (license_hash != null)
                {
                    license_hash = license_hash.ToUpper();
                }
                errorCode = LSAPI.VLSgetLicenseInfoExt(feature_name, version, capacity, feature_index, license_hash, license_hash_len, license_index, ref licenseInfo);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetLicenseInfoExt");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetLicenseInfoExt");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetLicenseInfoExt");
            }
            return num2;
        }

        public uint VLSgetLicInUseFromHandle(int lshandle, ref uint totalKeysIssued)
        {
            uint num3;
            uint errorCode = 0;
            try
            {
                int num2 = (int)totalKeysIssued;
                errorCode = LSAPI.VLSgetLicInUseFromHandle(lshandle, ref num2);
                totalKeysIssued = (uint)num2;
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num3 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetLicInUseFromHandle");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetLicInUseFromHandle");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetLicInUseFromHandle");
            }
            return num3;
        }

        public uint VLSgetLicSharingServerList(string feature_name, string feature_version, int server_list_len, StringBuilder server_list, ref int num_servers)
        {
            uint num2;
            if (server_list == null)
            {
                throw new Wechoid.Exception.CoreException(500, "Error[500]: API called with null value for parameter server_list:VLSgetLicSharingServerList ");
            }
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSgetLicSharingServerList(feature_name, feature_version, server_list_len, server_list, ref num_servers);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetLicSharingServerList");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetLicSharingServerList");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetLicSharingServerList");
            }
            return num2;
        }

        public uint VLSgetMachineID(uint lock_selector_in, ref VLSmachineID machineId, ref uint lock_selector_out)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSgetMachineID(lock_selector_in, ref machineId, ref lock_selector_out);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetMachineID");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetMachineID");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetMachineID");
            }
            return num2;
        }

        public uint VLSgetMachineIDOld(uint lock_selector_in, ref VLSmachineID machineID, ref uint lock_selector_out)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSgetMachineIDOld(lock_selector_in, ref machineID, ref lock_selector_out);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetMachineIDOld");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetMachineIDOld");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetMachineIDOld");
            }
            return num2;
        }

        public uint VLSgetMachineIDString(ref uint lock_selector, ref StringBuilder machineIDString)
        {
            uint num4;
            if (machineIDString == null)
            {
                throw new Wechoid.Exception.CoreException(500, "Error[500]: API called with null value for parameter machineIDString:VLSgetMachineIDString");
            }
            uint errorCode = 0;
            try
            {
                int num2 = (int)lock_selector;
                int bufSz = 0x400;
                StringBuilder builder = new StringBuilder(0x400);
                errorCode = LSAPI.VLSgetMachineIDString(ref num2, builder, ref bufSz);
                machineIDString = builder;
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num4 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetMachineIDString");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetMachineIDString");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetMachineIDString");
            }
            return num4;
        }

        public uint VLSgetNumberedMachineID(uint lock_selector_in, ref VLSmachineID machineID, ref uint lock_selector_out, int flag, int index)
        {
            uint num3;
            uint errorCode = 0;
            try
            {
                int reserved = 0;
                errorCode = LSAPI.VLSgetNumberedMachineID(lock_selector_in, ref machineID, ref lock_selector_out, flag, index, reserved);
                if ((errorCode != 0) && (errorCode != 0xd3))
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num3 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetNumberedMachineID");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetNumberedMachineID");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetNumberedMachineID");
            }
            return num3;
        }

        public uint VLSgetNumberedMachineIDExt(string server_name, uint lock_selector_in, ref VLSmachineID machineID, ref uint lock_selector_out, int flag, int index)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSgetNumberedMachineIDExt(server_name, lock_selector_in, ref machineID, ref lock_selector_out, flag, index, 0);
                if ((errorCode != 0) && (errorCode != 0xd3))
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetNumberedMachineIDExt");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetNumberedMachineIDExt");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetNumberedMachineIDExt");
            }
            return num2;
        }

        public uint VLSgetOutputCP(ref int cp)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSgetOutputCP(ref cp);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetOutputCP");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetOutputCP");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetOutputCP");
            }
            return num2;
        }

        public uint VLSgetPoolServerList(StringBuilder outBuf, int outBufSz)
        {
            uint num2;
            if (outBuf == null)
            {
                throw new Wechoid.Exception.CoreException(500, "Error[500]: API called with null value for parameter outBuf:VLSgetPoolServerList");
            }
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSgetPoolServerList(outBuf, outBufSz);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetPoolServerList");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetPoolServerList");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetPoolServerList");
            }
            return num2;
        }

        public uint VLSgetQueuedClientInfo(string feature_name, string version, ref VLSqueuedClientInfo[] vLSqueuedClientInfoArray)
        {
            uint num4;
            ArrayList list = new ArrayList();
            bool flag = false;
            uint errorCode = 0;
            int index = 0;
            VLSqueuedClientInfo info = new VLSqueuedClientInfo();
            int newSize = 0;
            try
            {
                do
                {
                    errorCode = LSAPI.VLSgetQueuedClientInfo(feature_name, version, index, null, ref info);
                    switch (errorCode)
                    {
                        case 0:
                            list.Add(info);
                            break;

                        case 9:
                            flag = true;
                            break;
                    }
                    index++;
                }
                while (!flag && (errorCode == 0));
                newSize = list.Count;
                Array.Resize<VLSqueuedClientInfo>(ref vLSqueuedClientInfoArray, newSize);
                vLSqueuedClientInfoArray = (VLSqueuedClientInfo[])list.ToArray(typeof(VLSqueuedClientInfo));
                if ((errorCode == 10) && (newSize != 0))
                {
                    errorCode = 0;
                }
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num4 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetQueuedClientInfo");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetQueuedClientInfo");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetQueuedClientInfo");
            }
            return num4;
        }

        public uint VLSgetQueuedClientInfo(string feature_name, string version, int index, ref VLSqueuedClientInfo client_info)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSgetQueuedClientInfo(feature_name, version, index, null, ref client_info);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetQueuedClientInfo");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetQueuedClientInfo");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetQueuedClientInfo");
            }
            return num2;
        }

        public uint VLSgetQueuedLicense(int lshandle, string log_comment)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                CHALLENGE challenge = new CHALLENGE();
                errorCode = LSAPI.VLSgetQueuedLicense(lshandle, log_comment, ref challenge);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetQueuedLicense");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetQueuedLicense");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetQueuedLicense");
            }
            return num2;
        }

        public uint VLSgetRenewalStatus()
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSgetRenewalStatus();
                if (((errorCode != 0) && (errorCode != 0x16)) && ((errorCode != 0x15) && (errorCode != 0x26)))
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetRenewalStatus");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetRenewalStatus");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetRenewalStatus");
            }
            return num2;
        }

        public uint VLSgetServerList(StringBuilder outBuf, int outBufSz)
        {
            uint num2;
            if (outBuf == null)
            {
                throw new Wechoid.Exception.CoreException(500, "Error[500]: API called with null value for parameter outBuf:VLSgetServerList");
            }
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSgetServerList(outBuf, outBufSz);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetServerList");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetServerList");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetServerList");
            }
            return num2;
        }

        public uint VLSgetServerNameFromHandle(int handle_id, ref StringBuilder outBuf)
        {
            uint num3;
            if (outBuf == null)
            {
                throw new Wechoid.Exception.CoreException(500, "Error[500]: API called with null value for parameter outBuf:VLSgetServerNameFromHandle");
            }
            uint errorCode = 0;
            try
            {
                outBuf = new StringBuilder(0x80);
                int outBufSz = 0x80;
                errorCode = LSAPI.VLSgetServerNameFromHandle(handle_id, outBuf, outBufSz);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num3 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetServerNameFromHandle");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetServerNameFromHandle");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetServerNameFromHandle");
            }
            return num3;
        }

        public uint VLSgetServerPort()
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSgetServerPort();
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetServerPort");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetServerPort");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetServerPort");
            }
            return num2;
        }

        public uint VLSgetServInfo(string server_name, ref VLSservInfo srv_info)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSgetServInfo(server_name, ref srv_info, null, 0);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetServInfo");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetServInfo");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetServInfo");
            }
            return num2;
        }

        public uint VLSgetTimeDriftFromHandle(int lshandle, ref uint secondsServerAheadOfClient)
        {
            uint num3;
            uint errorCode = 0;
            try
            {
                int num2 = (int)secondsServerAheadOfClient;
                errorCode = LSAPI.VLSgetTimeDriftFromHandle(lshandle, ref num2);
                secondsServerAheadOfClient = (uint)num2;
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num3 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetTimeDriftFromHandle");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetTimeDriftFromHandle");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetTimeDriftFromHandle");
            }
            return num3;
        }

        public uint VLSgetTimeoutInterval()
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = (uint)LSAPI.VLSgetTimeoutInterval();
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetTimeoutInterval");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetTimeoutInterval");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetTimeoutInterval");
            }
            return num2;
        }

        public uint VLSgetTrialPeriodLeft(string feature_name, string version, ref uint trialperiod)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSgetTrialPeriodLeft(feature_name, version, ref trialperiod, null);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetTrialPeriodLeft");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetTrialPeriodLeft");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetTrialPeriodLeft");
            }
            return num2;
        }

        public uint VLSgetTrialUsageInfo(ref VLStrialUsageInfo[] vlsTrialInfoArray)
        {
            VLStrialUsageInfo info = new VLStrialUsageInfo();
            uint num4;
            ArrayList list = new ArrayList();
            bool flag = false;
            int num2 = 0;
            info = new VLStrialUsageInfo
            {
                structSz = Marshal.SizeOf(info)
            };
            int newSize = 0;
            uint errorCode = LSAPI.VLSerrorHandle(0);
            try
            {
                do
                {
                    switch (LSAPI.VLSgetTrialUsageInfo(null, null, num2, ref info))
                    {
                        case 0:
                            list.Add(info);
                            break;

                        case 10:
                            flag = true;
                            break;

                        default:
                            errorCode = 0;
                            break;
                    }
                    num2++;
                }
                while (!flag && (errorCode == 0));
                newSize = list.Count;
                Array.Resize<VLStrialUsageInfo>(ref vlsTrialInfoArray, newSize);
                vlsTrialInfoArray = (VLStrialUsageInfo[])list.ToArray(typeof(VLStrialUsageInfo));
                if ((errorCode == 10) && (newSize != 0))
                {
                    errorCode = 0;
                }
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num4 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetTrialUsageInfo");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetTrialUsageInfo");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetTrialUsageInfo");
            }
            return num4;
        }

        public uint VLSgetTrialUsageInfo(string feature_name, string version, int feature_index, ref VLStrialUsageInfo trial_usage_info)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSgetTrialUsageInfo(feature_name, version, feature_index, ref trial_usage_info);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetTrialUsageInfo");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetTrialUsageInfo");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetTrialUsageInfo");
            }
            return num2;
        }

        public uint VLSgetUsageLogFileName(string hostname, StringBuilder fileName)
        {
            uint num2;
            if (fileName == null)
            {
                throw new Wechoid.Exception.CoreException(500, "Error[500]: API called with null value for parameter fileName:VLSgetUsageLogFileName");
            }
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSgetUsageLogFileName(hostname, fileName);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetUsageLogFileName");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetUsageLogFileName");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetUsageLogFileName");
            }
            return num2;
        }

        public uint VLSgetVersionFromHandle(int lshandle, ref StringBuilder Buffer)
        {
            uint num3;
            if (Buffer == null)
            {
                throw new Wechoid.Exception.CoreException(500, "Error[500]: API called with null value for parameter Buffer:VLSgetVersionFromHandle");
            }
            uint errorCode = 0;
            try
            {
                StringBuilder buffer = new StringBuilder(12);
                uint bufferSize = 12;
                errorCode = LSAPI.VLSgetVersionFromHandle(lshandle, buffer, bufferSize);
                if (buffer != null)
                {
                    Buffer = new StringBuilder(buffer.ToString());
                }
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num3 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetVersionFromHandle");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetVersionFromHandle");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetVersionFromHandle");
            }
            return num3;
        }

        public uint VLSgetVersions(string feature_name, int bufferSize, StringBuilder versionList)
        {
            uint num2;
            if (versionList == null)
            {
                throw new Wechoid.Exception.CoreException(500, "Error[500]: API called with null value for parameter versionList:VLSgetVersions");
            }
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSgetVersions(feature_name, bufferSize, versionList, null);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSgetVersions");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSgetVersions");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSgetVersions");
            }
            return num2;
        }

        public uint VLSinitialize()
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSinitialize();
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSinitialize");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSinitialize");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSinitialize");
            }
            return num2;
        }

        public uint VLSinitMachineID(ref VLSmachineID machineId)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSinitMachineID(ref machineId);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSinitMachineID");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + "VLSinitMachineID:");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + "VLSinitMachineID:");
            }
            return num2;
        }

        public uint VLSinitQueuePreference(ref VLSqueuePreference qPreference)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSinitQueuePreference(ref qPreference);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSinitQueuePreference");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSinitQueuePreference");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSinitQueuePreference");
            }
            return num2;
        }

        public uint VLSinitServerInfo(ref object serverInfo)
        {
            uint num2;
            if (serverInfo == null)
            {
                throw new Wechoid.Exception.CoreException(500, "Error[500]: API called with null value for parameter serverInfo:VLSinitServerInfo");
            }
            uint errorCode = 0;
            try
            {
                VLSserverInfo info = new VLSserverInfo();
                info = (VLSserverInfo)serverInfo;
                errorCode = LSAPI.VLSinitServerInfo(ref info);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                serverInfo = info;
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSinitServerInfo");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSinitServerInfo");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSinitServerInfo");
            }
            return num2;
        }

        public uint VLSinitServerList(string ServerList, int option_flag)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSinitServerList(ServerList, option_flag);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSinitServerList");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSinitServerList");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSinitServerList");
            }
            return num2;
        }

        public uint VLSinstallCommuterCode(string commuter_code)
        {
            uint num3;
            uint errorCode = 0;
            try
            {
                uint num2 = 0;
                errorCode = LSAPI.VLSinstallCommuterCode(commuter_code, null, num2);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num3 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSinstallCommuterCode");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSinstallCommuterCode");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSinstallCommuterCode");
            }
            return num3;
        }

        public Wechoid.Const.Const.VLS_LOC_UPD_STAT VLSisLocalRenewalDisabled()
        {
            Wechoid.Const.Const.VLS_LOC_UPD_STAT vls_loc_upd_stat;
            uint errorCode = 0;
            try
            {
                errorCode = (uint)LSAPI.VLSisLocalRenewalDisabled();
                if ((errorCode != 0) && (errorCode != 1))
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                vls_loc_upd_stat = (Wechoid.Const.Const.VLS_LOC_UPD_STAT)errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSisLocalRenewalDisabled");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSisLocalRenewalDisabled");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSisLocalRenewalDisabled");
            }
            return vls_loc_upd_stat;
        }

        public uint VLSisVirtualMachine(ref VLSVMInfo vm_info)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSisVirtualMachine(ref vm_info);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSisVirtualMachine");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSisVirtualMachine");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSisVirtualMachine");
            }
            return num2;
        }

        public uint VLSlicense(string FeatureName, string Version, ref int handle)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSlicense(FeatureName, Version, ref handle);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSlicense");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSlicense");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSlicense");
            }
            return num2;
        }

        public uint VLSmachineIDtoLockCode(ref VLSmachineID machineId, uint lock_selector, ref uint lockCode)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSmachineIDtoLockCode(ref machineId, lock_selector, ref lockCode);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSmachineIDtoLockCode");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSmachineIDtoLockCode");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSmachineIDtoLockCode");
            }
            return num2;
        }

        public uint VLSmachineIDToLockCodeEx(ref VLSmachineID machineID, uint lock_selector, ref StringBuilder lockCode)
        {
            uint num3;
            if (lockCode == null)
            {
                throw new Wechoid.Exception.CoreException(500, "Error[500]: API called with null value for parameter lockCode:VLSmachineIDToLockCodeEx");
            }
            uint errorCode = 0;
            try
            {
                StringBuilder builder = new StringBuilder(20);
                int lockCodeLen = 20;
                errorCode = LSAPI.VLSmachineIDToLockCodeEx(ref machineID, lock_selector, builder, lockCodeLen, 0);
                lockCode = builder;
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num3 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSmachineIDToLockCodeEx");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSmachineIDToLockCodeEx");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSmachineIDToLockCodeEx");
            }
            return num3;
        }

        public uint VLSqueuedRequest(string license_system, string publisher_name, string product_name, string version, ref uint units_reqd, string log_comment, ref object challenge, ref int lshandle, ref VLSqueuePreference qPreference, ref int requestFlag)
        {
            uint num3;
            uint errorCode = 0;
            try
            {
                CHALLENGE challenge2 = new CHALLENGE();
                if (challenge != null)
                {
                    challenge2 = (CHALLENGE)challenge;
                }
                int num2 = (int)units_reqd;
                errorCode = LSAPI.VLSqueuedRequest(license_system, publisher_name, product_name, version, ref num2, log_comment, ref challenge2, ref lshandle, ref qPreference, ref requestFlag);
                units_reqd = (uint)num2;
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                if (challenge != null)
                {
                    challenge = challenge2;
                }
                num3 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSqueuedRequest");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSqueuedRequest");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSqueuedRequest");
            }
            return num3;
        }

        public uint VLSqueuedRequestExt(string license_system, string publisher_name, string product_name, string version, ref uint units_reqd, string log_comment, ref object challenge, ref int lshandle, ref VLSqueuePreference qPreference, ref int requestFlag, ref object serverInfo)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                CHALLENGE challenge2 = new CHALLENGE();
                if (challenge != null)
                {
                    challenge2 = (CHALLENGE)challenge;
                }
                VLSserverInfo info = new VLSserverInfo();
                if (serverInfo != null)
                {
                    info = (VLSserverInfo)serverInfo;
                }
                errorCode = LSAPI.VLSqueuedRequestExt(license_system, publisher_name, product_name, version, ref units_reqd, log_comment, ref challenge2, ref lshandle, ref qPreference, ref requestFlag, ref info);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                if (challenge != null)
                {
                    challenge = challenge2;
                }
                if (serverInfo != null)
                {
                    serverInfo = info;
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSqueuedRequestExt");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSqueuedRequestExt");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSqueuedRequestExt");
            }
            return num2;
        }

        public uint VLSreleaseExt(int lshandle, uint units_consumed, string log_comment, ref object serverInfo)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                VLSserverInfo info = new VLSserverInfo();
                if (serverInfo != null)
                {
                    info = (VLSserverInfo)serverInfo;
                }
                errorCode = LSAPI.VLSreleaseExt(lshandle, units_consumed, log_comment, ref info);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                if (serverInfo != null)
                {
                    serverInfo = info;
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSreleaseExt");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSreleaseExt");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSreleaseExt");
            }
            return num2;
        }

        public uint VLSremoveQueue(string feature_name, string version, string log_comment)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSremoveQueue(feature_name, version, log_comment);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSremoveQueue");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSremoveQueue");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSremoveQueue");
            }
            return num2;
        }

        public uint VLSremoveQueuedClient(string feature_name, string version, int qkey_id, string log_comment)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSremoveQueuedClient(feature_name, version, qkey_id, log_comment);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSremoveQueuedClient");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSremoveQueuedClient");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSremoveQueuedClient");
            }
            return num2;
        }

        public uint VLSrequestExt(string license_system, string publisher_name, string product_name, string version, ref uint units_reqd, string log_comment, ref object challenge, ref int lshandle, ref object serverInfo)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                CHALLENGE challenge2 = new CHALLENGE();
                if (challenge != null)
                {
                    challenge2 = (CHALLENGE)challenge;
                }
                VLSserverInfo info = new VLSserverInfo();
                if (serverInfo != null)
                {
                    info = (VLSserverInfo)serverInfo;
                }
                errorCode = LSAPI.VLSrequestExt(license_system, publisher_name, product_name, version, ref units_reqd, log_comment, ref challenge2, ref lshandle, ref info);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                if (challenge != null)
                {
                    challenge = challenge2;
                }
                if (serverInfo != null)
                {
                    serverInfo = info;
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSrequestExt");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSrequestExt");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSrequestExt");
            }
            return num2;
        }

        public uint VLSrequestExt2(string license_system, string publisher_name, string product_name, string version, ref uint units_reqd, string log_comment, ref object challenge, ref int lshandle, ref object serverInfo, object team_capacity_reqd, object capacity_reqd, ref uint special_flag)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                object obj2 = team_capacity_reqd;
                object obj3 = capacity_reqd;
                CHALLENGE challenge2 = new CHALLENGE();
                if (challenge != null)
                {
                    challenge2 = (CHALLENGE)challenge;
                }
                VLSserverInfo info = new VLSserverInfo();
                if (serverInfo != null)
                {
                    info = (VLSserverInfo)serverInfo;
                }
                errorCode = LSAPI.VLSrequestExt2(license_system, publisher_name, product_name, version, ref units_reqd, log_comment, ref challenge2, ref lshandle, ref info, obj2, obj3, null, ref special_flag);
                team_capacity_reqd = obj2;
                capacity_reqd = obj3;
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                if (challenge != null)
                {
                    challenge = challenge2;
                }
                if (serverInfo != null)
                {
                    serverInfo = info;
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSrequestExt2");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSrequestExt2");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSrequestExt2");
            }
            return num2;
        }

        public uint VLSrevokeByPermissionTicket(string pucServerName, string pucPassword, byte[] pucPermissionTicket, uint ui16PermissionTicketLength, ref byte[] pucRevocationTicket)
        {
            uint num6;
            uint errorCode = 0;
            if (pucRevocationTicket == null)
            {
                throw new Wechoid.Exception.CoreException(500, "Error[500]: API called with null value for parameter pucRevocationTicket:VLSrevokeByPermissionTicket");
            }
            try
            {
                uint num2 = 0;
                byte[] buffer = null;
                uint num3 = 0;
                byte[] buffer2 = new byte[ui16PermissionTicketLength];
                int index = 0;
                for (int i = 0; i < ui16PermissionTicketLength; i++)
                {
                    index = i + 1;
                    if ((pucPermissionTicket[i] == 13) && (pucPermissionTicket[index] == 10))
                    {
                        num3++;
                    }
                    else
                    {
                        buffer2[(int)((IntPtr)(i - num3))] = pucPermissionTicket[i];
                    }
                }
                ui16PermissionTicketLength -= num3;
                errorCode = LSAPI.VLSrevokeByPermissionTicket(null, null, buffer2, ui16PermissionTicketLength, null, ref num2);
                if (errorCode == 0)
                {
                    buffer = new byte[num2];
                    errorCode = LSAPI.VLSrevokeByPermissionTicket(null, null, buffer2, ui16PermissionTicketLength, buffer, ref num2);
                }
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                pucRevocationTicket = buffer;
                num6 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSrevokeByPermissionTicket");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSrevokeByPermissionTicket");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSrevokeByPermissionTicket");
            }
            return num6;
        }

        public uint VLSrevokeLicense(string server_name, string feature_name, string feature_version, string password, ref uint units_to_revoke, StringBuilder rvk_ticket, ref int length_of_rvk_ticket, string log_comment)
        {
            uint num4;
            if (rvk_ticket == null)
            {
                throw new Wechoid.Exception.CoreException(500, "Error[500]: API called with null value for parameter rvk_ticket:VLSrevokeLicense");
            }
            uint errorCode = 0;
            try
            {
                uint num2 = 0;
                int num3 = (int)units_to_revoke;
                errorCode = LSAPI.VLSrevokeLicense(server_name, feature_name, feature_version, null, password, ref num3, null, rvk_ticket, ref length_of_rvk_ticket, log_comment, ref num2, null);
                units_to_revoke = (uint)num3;
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num4 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSrevokeLicense");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSrevokeLicense");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSrevokeLicense");
            }
            return num4;
        }

        public uint VLSsetBroadcastInterval(int interval)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSsetBroadcastInterval(interval);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSsetBroadcastInterval");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSsetBroadcastInterval");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSsetBroadcastInterval");
            }
            return num2;
        }

        public uint VLSsetConsumeLimit(int iHandle, Wechoid.Const.Const.CONSUME_LIMIT_TYPE consume_type, Wechoid.Const.Const.CONSUME_OPERATION_TYPE consume_op_type, ref int consume_value)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                CHALLENGE challenge = new CHALLENGE();
                errorCode = LSAPI.VLSsetConsumeLimit(iHandle, consume_type, consume_op_type, ref consume_value, ref challenge);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSsetConsumeLimit");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSsetConsumeLimit");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSsetConsumeLimit");
            }
            return num2;
        }

        public uint VLSsetContactServer(string server_name)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSsetContactServer(server_name);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSsetContactServer");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSsetContactServer");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSsetContactServer");
            }
            return num2;
        }

        public uint VLSsetContextData(int iHandle, string context_buff, uint buff_len)
        {
            uint num2;
            if (context_buff == null)
            {
                throw new Wechoid.Exception.CoreException(500, "Error[500]: API called with null value for parameter context_buff:VLSsetContextData");
            }
            uint errorCode = 0;
            try
            {
                CHALLENGE challenge = new CHALLENGE();
                errorCode = LSAPI.VLSsetContextData(iHandle, context_buff, buff_len, ref challenge);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSsetContextData");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSsetContextData");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSsetContextData");
            }
            return num2;
        }

        public uint VLSsetErrorHandler(LSAPI.VLSsetErrorHandlerDelegate del, int LS_ErrorType)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSsetErrorHandler(del, LS_ErrorType);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSsetErrorHandler");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSsetErrorHandler");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSsetErrorHandler");
            }
            return num2;
        }

        public uint VLSsetFileName(Wechoid.Const.Const.VLS_FILE_TYPE filetype, string fileName)
        {
            uint num3;
            uint errorCode = 0;
            try
            {
                uint num2 = 0;
                errorCode = LSAPI.VLSsetFileName(filetype, fileName, null, ref num2);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num3 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSsetFileName");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSsetFileName");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSsetFileName");
            }
            return num3;
        }

        public uint VLSsetGraceRequestFlag(int state)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSsetGraceRequestFlag(state);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSsetGraceRequestFlag");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSsetGraceRequestFlag");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSsetGraceRequestFlag");
            }
            return num2;
        }

        public uint VLSsetHoldTime(string feature_name, string version, int hold_time)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSsetHoldTime(feature_name, version, hold_time);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSsetHoldTime");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSsetHoldTime");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSsetHoldTime");
            }
            return num2;
        }

        public uint VLSsetHostIdFunc(LSAPI.VLSsetmyHostIdFunc del)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSsetHostIdFunc(del);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSsetHostIdFunc");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSsetHostIdFunc");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSsetHostIdFunc");
            }
            return num2;
        }

        public uint VLSsetLicensePrecedence(string feature_name, string version, string license_hash, int license_hash_len, int precedence_level)
        {
            uint num3;
            if (license_hash == null)
            {
                throw new Wechoid.Exception.CoreException(500, "Error[500]: API called with null value for parameter license_hash:VLSsetLicensePrecedence");
            }
            uint errorCode = 0;
            try
            {
                int num2 = 0;
                license_hash = license_hash.ToUpper();
                errorCode = LSAPI.VLSsetLicensePrecedence(feature_name, version, license_hash, license_hash_len, precedence_level, ref num2, num2);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num3 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSsetLicensePrecedence");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSsetLicensePrecedence");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSsetLicensePrecedence");
            }
            return num3;
        }

        public uint VLSsetOutputCP(int cp)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSsetOutputCP(cp);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSsetOutputCP");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSsetOutputCP");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSsetOutputCP");
            }
            return num2;
        }

        public uint VLSsetRemoteRenewalTime(string feature_name, string version, int renewal_time)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSsetRemoteRenewalTime(feature_name, version, renewal_time);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSsetRemoteRenewalTime");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSsetRemoteRenewalTime");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSsetRemoteRenewalTime");
            }
            return num2;
        }

        public uint VLSsetServerLogState(int _event, int state)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSsetServerLogState(_event, state);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSsetServerLogState");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSsetServerLogState");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSsetServerLogState");
            }
            return num2;
        }

        public void VLSsetServerPort(int port_number)
        {
            uint errorCode = 0;
            try
            {
                LSAPI.VLSsetServerPort(port_number);
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSsetServerPort");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSsetServerPort");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSsetServerPort");
            }
        }

        public uint VLSsetSharedIdValue(int shared_id, string sharedIdValue)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                if (sharedIdValue == null)
                {
                    sharedIdValue = "";
                }
                errorCode = LSAPI.VLSsetSharedIdValue(shared_id, sharedIdValue);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSsetSharedIdValue");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSsetSharedIdValue");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSsetSharedIdValue");
            }
            return num2;
        }

        public uint VLSsetTimeoutInterval(int interval)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSsetTimeoutInterval(interval);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSsetTimeoutInterval");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSsetTimeoutInterval");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSsetTimeoutInterval");
            }
            return num2;
        }

        public uint VLSsetTraceHandler(LSAPI.VLSsetTraceHandlerDelegate TraceHandlerDelegate)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSsetTraceHandler(TraceHandlerDelegate);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSsetTraceHandler");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSsetTraceHandler");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSsetTraceHandler");
            }
            return num2;
        }

        public uint VLSsetTraceLevel(int trace_level)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSsetTraceLevel(trace_level);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSsetTraceLevel");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSsetTraceLevel");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSsetTraceLevel");
            }
            return num2;
        }

        public uint VLSsetUserErrorFile(Wechoid.Const.Const.VLS_ERR_FILE msgFile, string filePath)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSsetUserErrorFile(msgFile, filePath);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSsetUserErrorFile");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSsetUserErrorFile");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSsetUserErrorFile");
            }
            return num2;
        }

        public uint VLSsetUserTraceFile(int msgFile, string filePath)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSsetUserTraceFile(msgFile, filePath);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSsetUserTraceFile");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSsetUserTraceFile");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSsetUserTraceFile");
            }
            return num2;
        }

        public uint VLSshutDown(string hostname)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSshutDown(hostname);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSshutDown");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSshutDown");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSshutDown");
            }
            return num2;
        }

        public uint VLSuninstallAndReturnCommuterCode(string feature_name, string feature_version, string log_comment)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSuninstallAndReturnCommuterCode(feature_name, feature_version, log_comment);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSuninstallAndReturnCommuterCode");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSuninstallAndReturnCommuterCode");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSuninstallAndReturnCommuterCode");
            }
            return num2;
        }

        public uint VLSupdateQueuedClient(int lshandle, ref int absExpiryTime)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                CHALLENGE challenge = new CHALLENGE();
                errorCode = LSAPI.VLSupdateQueuedClient(lshandle, ref absExpiryTime, null, ref challenge);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSupdateQueuedClient");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSupdateQueuedClient");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSupdateQueuedClient");
            }
            return num2;
        }

        public uint VLSusageAuthenticate(string file_name, ref VLSerrorLine[] error_line)
        {
            uint num4;
            uint errorCode = 0;
            try
            {
                int len = 0;
                VLSerrorLine[] lineArray = null;
                errorCode = LSAPI.VLSusageAuthenticate(file_name, ref len, ref lineArray);
                if ((errorCode == 0xdf) && (len > 0))
                {
                    lineArray = new VLSerrorLine[len];
                    for (int i = 0; i < len; i++)
                    {
                        lineArray[i] = new VLSerrorLine();
                    }
                    errorCode = LSAPI.VLSusageAuthenticate(file_name, ref len, ref lineArray);
                }
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num4 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSusageFileDecrypt");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSusageFileDecrypt");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSusageFileDecrypt");
            }
            return num4;
        }

        public uint VLSusageFileDecrypt(string file_name, string Option_field, string Output_file_name)
        {
            uint num2;
            uint errorCode = 0;
            try
            {
                errorCode = LSAPI.VLSusageFileDecrypt(file_name, Option_field, Output_file_name);
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, this.GetErrorMsgString(errorCode));
                }
                num2 = errorCode;
            }
            catch (Wechoid.Exception.CoreException exception)
            {
                throw new Wechoid.Exception.CoreException(exception.getErrorCode(), exception.getErrorMessage() + ":VLSusageFileDecrypt");
            }
            catch (System.Exception exception2)
            {
                if (errorCode != 0)
                {
                    throw new Wechoid.Exception.CoreException(errorCode, exception2.ToString() + ":VLSusageFileDecrypt");
                }
                throw new Wechoid.Exception.CoreException(0x1f5, exception2.ToString() + ":VLSusageFileDecrypt");
            }
            return num2;
        }

    }
}
