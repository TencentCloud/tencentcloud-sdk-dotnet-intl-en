/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Instance : AbstractModel
    {
        
        /// <summary>
        /// Instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Instance name, such as `ens-34241f3s`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Instance status. Valid values:
        /// PENDING: creating
        /// LAUNCH_FAILED: failed to create
        /// RUNNING: running
        /// STOPPED: shut down
        /// STARTING: starting
        /// STOPPING: shutting down
        /// REBOOTING: restarting
        /// SHUTDOWN: to be terminated
        /// TERMINATING: terminating.
        /// </summary>
        [JsonProperty("InstanceState")]
        public string InstanceState{ get; set; }

        /// <summary>
        /// Information of the image currently used by the instance.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Image")]
        public Image Image{ get; set; }

        /// <summary>
        /// Basic information of the current module of the instance.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SimpleModule")]
        public SimpleModule SimpleModule{ get; set; }

        /// <summary>
        /// Location information of the instance.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Position")]
        public Position Position{ get; set; }

        /// <summary>
        /// Network information of the instance.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Internet")]
        public Internet Internet{ get; set; }

        /// <summary>
        /// Configuration information of the instance.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceTypeConfig")]
        public InstanceTypeConfig InstanceTypeConfig{ get; set; }

        /// <summary>
        /// Instance creation time.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Instance tag information.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }

        /// <summary>
        /// Last operation on the instance.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LatestOperation")]
        public string LatestOperation{ get; set; }

        /// <summary>
        /// Result of the last operation on the instance.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LatestOperationState")]
        public string LatestOperationState{ get; set; }

        /// <summary>
        /// Instance business status. Valid values:
        /// NORMAL: normal
        /// EXPIRED: expired
        /// PROTECTIVELY_ISOLATED: isolated.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RestrictState")]
        public string RestrictState{ get; set; }

        /// <summary>
        /// System disk size in GB.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SystemDiskSize")]
        public long? SystemDiskSize{ get; set; }

        /// <summary>
        /// Data disk size in GB.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DataDiskSize")]
        public long? DataDiskSize{ get; set; }

        /// <summary>
        /// Instance UUID
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UUID")]
        public string UUID{ get; set; }

        /// <summary>
        /// Billing mode.
        ///     0: postpaid.
        ///     1: prepaid.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// Expiration time in the format of `yyyy-mm-dd HH:mm:ss`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// Isolation time in the format of `yyyy-mm-dd HH:mm:ss`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsolatedTime")]
        public string IsolatedTime{ get; set; }

        /// <summary>
        /// Auto-Renewal flag.
        ///       0: no.
        ///       1: yes.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RenewFlag")]
        public long? RenewFlag{ get; set; }

        /// <summary>
        /// Expiration status.
        ///     NORMAL: normal.
        ///     WILL_EXPIRE: about to expire.
        ///     EXPIRED: expired.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExpireState")]
        public string ExpireState{ get; set; }

        /// <summary>
        /// System disk information
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SystemDisk")]
        public DiskInfo SystemDisk{ get; set; }

        /// <summary>
        /// Data disk information
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DataDisks")]
        public DiskInfo[] DataDisks{ get; set; }

        /// <summary>
        /// New instance flag
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NewFlag")]
        public long? NewFlag{ get; set; }

        /// <summary>
        /// Security group of the instance, which can be obtained from the `sgId` field in the returned value of the `DescribeSecurityGroups` API.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// VPC attribute
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VirtualPrivateCloud")]
        public VirtualPrivateCloud VirtualPrivateCloud{ get; set; }

        /// <summary>
        /// ISP field of the instance.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ISP")]
        public string ISP{ get; set; }

        /// <summary>
        /// Physical location information. Note that this field is currently a reserved field and null.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PhysicalPosition")]
        public PhysicalPosition PhysicalPosition{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceState", this.InstanceState);
            this.SetParamObj(map, prefix + "Image.", this.Image);
            this.SetParamObj(map, prefix + "SimpleModule.", this.SimpleModule);
            this.SetParamObj(map, prefix + "Position.", this.Position);
            this.SetParamObj(map, prefix + "Internet.", this.Internet);
            this.SetParamObj(map, prefix + "InstanceTypeConfig.", this.InstanceTypeConfig);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
            this.SetParamSimple(map, prefix + "LatestOperation", this.LatestOperation);
            this.SetParamSimple(map, prefix + "LatestOperationState", this.LatestOperationState);
            this.SetParamSimple(map, prefix + "RestrictState", this.RestrictState);
            this.SetParamSimple(map, prefix + "SystemDiskSize", this.SystemDiskSize);
            this.SetParamSimple(map, prefix + "DataDiskSize", this.DataDiskSize);
            this.SetParamSimple(map, prefix + "UUID", this.UUID);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "IsolatedTime", this.IsolatedTime);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "ExpireState", this.ExpireState);
            this.SetParamObj(map, prefix + "SystemDisk.", this.SystemDisk);
            this.SetParamArrayObj(map, prefix + "DataDisks.", this.DataDisks);
            this.SetParamSimple(map, prefix + "NewFlag", this.NewFlag);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamObj(map, prefix + "VirtualPrivateCloud.", this.VirtualPrivateCloud);
            this.SetParamSimple(map, prefix + "ISP", this.ISP);
            this.SetParamObj(map, prefix + "PhysicalPosition.", this.PhysicalPosition);
        }
    }
}

