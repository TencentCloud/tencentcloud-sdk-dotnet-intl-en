/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Instance : AbstractModel
    {
        
        /// <summary>
        /// Location of the instance
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// Instance `ID`
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Instance model
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Number of CPU cores of the instance; unit: core
        /// </summary>
        [JsonProperty("CPU")]
        public long? CPU{ get; set; }

        /// <summary>
        /// Instance memory capacity. unit: GiB.
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// Instance business status. valid values:<br><li>NORMAL: indicates an instance in the NORMAL state</li><li>EXPIRED: indicates an EXPIRED instance</li><li>PROTECTIVELY_ISOLATED: PROTECTIVELY ISOLATED instance</li>.
        /// </summary>
        [JsonProperty("RestrictState")]
        public string RestrictState{ get; set; }

        /// <summary>
        /// Instance name
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Instance billing plan. Valid values:<br><li>`POSTPAID_BY_HOUR`: pay after use. You are billed by the hour, by traffic.<br><li>`CDHPAID`: `CDH` billing plan. Applicable to `CDH` only, not the instances on the host.<br>
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// Information on the system disk of the instance
        /// </summary>
        [JsonProperty("SystemDisk")]
        public SystemDisk SystemDisk{ get; set; }

        /// <summary>
        /// Information of the instance data disks.
        /// </summary>
        [JsonProperty("DataDisks")]
        public DataDisk[] DataDisks{ get; set; }

        /// <summary>
        /// List of private IPs of the instance's primary ENI.
        /// </summary>
        [JsonProperty("PrivateIpAddresses")]
        public string[] PrivateIpAddresses{ get; set; }

        /// <summary>
        /// List of public IPs of the instance's primary ENI.
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("PublicIpAddresses")]
        public string[] PublicIpAddresses{ get; set; }

        /// <summary>
        /// Information on instance bandwidth.
        /// </summary>
        [JsonProperty("InternetAccessible")]
        public InternetAccessible InternetAccessible{ get; set; }

        /// <summary>
        /// Information on the VPC where the instance resides.
        /// </summary>
        [JsonProperty("VirtualPrivateCloud")]
        public VirtualPrivateCloud VirtualPrivateCloud{ get; set; }

        /// <summary>
        /// `ID` of the image used to create the instance.
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// AUTO-Renewal flag. valid values:<br><li>`NOTIFY_AND_MANUAL_RENEW`: indicates that a notification of impending expiration is made but AUTO-renewal is not performed</li><li>`NOTIFY_AND_AUTO_RENEW`: indicates that a notification of impending expiration is made AND AUTO-renewal is performed</li><li>`DISABLE_NOTIFY_AND_MANUAL_RENEW`: indicates that notification that it is about to expire is not made AND AUTO-renewal is not performed.
        /// Note: this field is null in postpaid mode.
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// Creation time following the `ISO8601` standard and using `UTC` time in the format of `YYYY-MM-DDThh:mm:ssZ`.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Expiration time in UTC format following the `ISO8601` standard: `YYYY-MM-DDThh:mm:ssZ`. Note: this parameter is `null` for postpaid instances.
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public string ExpiredTime{ get; set; }

        /// <summary>
        /// Operating system name.
        /// </summary>
        [JsonProperty("OsName")]
        public string OsName{ get; set; }

        /// <summary>
        /// Security groups to which the instance belongs. To obtain the security group IDs, you can call [DescribeSecurityGroups](https://intl.cloud.tencent.com/document/api/215/15808) and look for the `sgld` fields in the response.
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// Login settings of the instance. Currently only the key associated with the instance is returned.
        /// </summary>
        [JsonProperty("LoginSettings")]
        public LoginSettings LoginSettings{ get; set; }

        /// <summary>
        /// Instance status. for specific status types, see the instance status table (https://www.tencentcloud.comom/document/api/213/15753?from_cn_redirect=1#InstanceStatus).
        /// </summary>
        [JsonProperty("InstanceState")]
        public string InstanceState{ get; set; }

        /// <summary>
        /// List of tags associated with the instance.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Shutdown billing mode of an instance.
        /// 
        /// Valid values: <br><li>KEEP_CHARGING: billing continues after shutdown</li><li>STOP_CHARGING: billing stops after shutdown</li><li>NOT_APPLICABLE: the instance is NOT shut down or stopping billing after shutdown is NOT APPLICABLE to the instance</li>.
        /// </summary>
        [JsonProperty("StopChargingMode")]
        public string StopChargingMode{ get; set; }

        /// <summary>
        /// Globally unique ID of the instance.
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// Last operation of the instance, such as StopInstances or ResetInstance.
        /// </summary>
        [JsonProperty("LatestOperation")]
        public string LatestOperation{ get; set; }

        /// <summary>
        /// The latest operation status of the instance. valid values:<br><li>SUCCESS: indicates that the operation succeeded</li><li>OPERATING: indicates that the operation is in progress</li><li>FAILED: indicates that the operation FAILED</li>.
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("LatestOperationState")]
        public string LatestOperationState{ get; set; }

        /// <summary>
        /// Unique request ID for the last operation of the instance.
        /// </summary>
        [JsonProperty("LatestOperationRequestId")]
        public string LatestOperationRequestId{ get; set; }

        /// <summary>
        /// Spread placement group ID.
        /// </summary>
        [JsonProperty("DisasterRecoverGroupId")]
        public string DisasterRecoverGroupId{ get; set; }

        /// <summary>
        /// IPv6 address of the instance.
        /// Note: this field may return null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("IPv6Addresses")]
        public string[] IPv6Addresses{ get; set; }

        /// <summary>
        /// CAM role name.
        /// Note: this field may return null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("CamRoleName")]
        public string CamRoleName{ get; set; }

        /// <summary>
        /// High-performance computing cluster ID.
        /// </summary>
        [JsonProperty("HpcClusterId")]
        public string HpcClusterId{ get; set; }

        /// <summary>
        /// IP list of HPC cluster.
        /// Note: this field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("RdmaIpAddresses")]
        public string[] RdmaIpAddresses{ get; set; }

        /// <summary>
        /// Dedicated cluster ID where the instance is located.
        /// </summary>
        [JsonProperty("DedicatedClusterId")]
        public string DedicatedClusterId{ get; set; }

        /// <summary>
        /// Instance isolation type. valid values:<br><li>ARREAR: indicates arrears isolation<br></li><li>EXPIRE: indicates isolation upon expiration<br></li><li>MANMADE: indicates voluntarily refunded isolation<br></li><li>NOTISOLATED: indicates unisolated<br></li>.
        /// </summary>
        [JsonProperty("IsolatedSource")]
        public string IsolatedSource{ get; set; }

        /// <summary>
        /// GPU information. if it is a gpu type instance, this value will be returned. for other type instances, it does not return.
        /// </summary>
        [JsonProperty("GPUInfo")]
        public GPUInfo GPUInfo{ get; set; }

        /// <summary>
        /// Instance OS license type. Default value: `TencentCloud`
        /// </summary>
        [JsonProperty("LicenseType")]
        public string LicenseType{ get; set; }

        /// <summary>
        /// Instance destruction protection flag indicates whether an instance is allowed to be deleted through an api. value ranges from:<br><li>true: indicates that instance protection is enabled, deletion through apis is not allowed</li><li>false: indicates that instance protection is disabled, allow passage</li><br>default value: false.
        /// </summary>
        [JsonProperty("DisableApiTermination")]
        public bool? DisableApiTermination{ get; set; }

        /// <summary>
        /// Default login user
        /// </summary>
        [JsonProperty("DefaultLoginUser")]
        public string DefaultLoginUser{ get; set; }

        /// <summary>
        /// Default login port
        /// </summary>
        [JsonProperty("DefaultLoginPort")]
        public long? DefaultLoginPort{ get; set; }

        /// <summary>
        /// Latest operation errors of the instance.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LatestOperationErrorMsg")]
        public string LatestOperationErrorMsg{ get; set; }

        /// <summary>
        /// Custom metadata. this parameter corresponds to the metadata information specified when creating a CVM. **note: in beta test**.
        /// </summary>
        [JsonProperty("Metadata")]
        public Metadata Metadata{ get; set; }

        /// <summary>
        /// Specifies the public IPv6 address bound to the instance.
        /// </summary>
        [JsonProperty("PublicIPv6Addresses")]
        public string[] PublicIPv6Addresses{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Placement.", this.Placement);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "CPU", this.CPU);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "RestrictState", this.RestrictState);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamObj(map, prefix + "SystemDisk.", this.SystemDisk);
            this.SetParamArrayObj(map, prefix + "DataDisks.", this.DataDisks);
            this.SetParamArraySimple(map, prefix + "PrivateIpAddresses.", this.PrivateIpAddresses);
            this.SetParamArraySimple(map, prefix + "PublicIpAddresses.", this.PublicIpAddresses);
            this.SetParamObj(map, prefix + "InternetAccessible.", this.InternetAccessible);
            this.SetParamObj(map, prefix + "VirtualPrivateCloud.", this.VirtualPrivateCloud);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
            this.SetParamSimple(map, prefix + "OsName", this.OsName);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamObj(map, prefix + "LoginSettings.", this.LoginSettings);
            this.SetParamSimple(map, prefix + "InstanceState", this.InstanceState);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "StopChargingMode", this.StopChargingMode);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "LatestOperation", this.LatestOperation);
            this.SetParamSimple(map, prefix + "LatestOperationState", this.LatestOperationState);
            this.SetParamSimple(map, prefix + "LatestOperationRequestId", this.LatestOperationRequestId);
            this.SetParamSimple(map, prefix + "DisasterRecoverGroupId", this.DisasterRecoverGroupId);
            this.SetParamArraySimple(map, prefix + "IPv6Addresses.", this.IPv6Addresses);
            this.SetParamSimple(map, prefix + "CamRoleName", this.CamRoleName);
            this.SetParamSimple(map, prefix + "HpcClusterId", this.HpcClusterId);
            this.SetParamArraySimple(map, prefix + "RdmaIpAddresses.", this.RdmaIpAddresses);
            this.SetParamSimple(map, prefix + "DedicatedClusterId", this.DedicatedClusterId);
            this.SetParamSimple(map, prefix + "IsolatedSource", this.IsolatedSource);
            this.SetParamObj(map, prefix + "GPUInfo.", this.GPUInfo);
            this.SetParamSimple(map, prefix + "LicenseType", this.LicenseType);
            this.SetParamSimple(map, prefix + "DisableApiTermination", this.DisableApiTermination);
            this.SetParamSimple(map, prefix + "DefaultLoginUser", this.DefaultLoginUser);
            this.SetParamSimple(map, prefix + "DefaultLoginPort", this.DefaultLoginPort);
            this.SetParamSimple(map, prefix + "LatestOperationErrorMsg", this.LatestOperationErrorMsg);
            this.SetParamObj(map, prefix + "Metadata.", this.Metadata);
            this.SetParamArraySimple(map, prefix + "PublicIPv6Addresses.", this.PublicIPv6Addresses);
        }
    }
}

