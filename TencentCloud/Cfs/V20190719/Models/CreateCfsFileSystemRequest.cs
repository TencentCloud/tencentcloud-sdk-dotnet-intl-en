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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCfsFileSystemRequest : AbstractModel
    {
        
        /// <summary>
        /// AZ name, such as "ap-beijing-1". For the list of regions and AZs, please see [Overview](https://intl.cloud.tencent.com/document/product/582/13225?from_cn_redirect=1)
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Network type. Valid values: VPC (VPC), BASIC (basic network)
        /// </summary>
        [JsonProperty("NetInterface")]
        public string NetInterface{ get; set; }

        /// <summary>
        /// Permission group ID
        /// </summary>
        [JsonProperty("PGroupId")]
        public string PGroupId{ get; set; }

        /// <summary>
        /// File system protocol type. Valid values: NFS, CIFS. If this parameter is left empty, NFS will be used by default
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// File system storage class. Valid values: SD (standard), HP (high-performance)
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// VPC ID. This field is required if network type is VPC.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Subnet ID. This field is required if network type is VPC.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Specifies an IP address, which is supported only for VPC. If this parameter is left empty, a random IP will be assigned in the subnet
        /// </summary>
        [JsonProperty("MountIP")]
        public string MountIP{ get; set; }

        /// <summary>
        /// Custom file system name
        /// </summary>
        [JsonProperty("FsName")]
        public string FsName{ get; set; }

        /// <summary>
        /// File system tag
        /// </summary>
        [JsonProperty("ResourceTags")]
        public TagInfo[] ResourceTags{ get; set; }

        /// <summary>
        /// A unique string supplied by the client to ensure that the request is idempotent. Its maximum length is 64 ASCII characters. If this parameter is not specified, the idempotency of the request cannot be guaranteed. This string is valid for 2 hours.
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "NetInterface", this.NetInterface);
            this.SetParamSimple(map, prefix + "PGroupId", this.PGroupId);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "MountIP", this.MountIP);
            this.SetParamSimple(map, prefix + "FsName", this.FsName);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
        }
    }
}

