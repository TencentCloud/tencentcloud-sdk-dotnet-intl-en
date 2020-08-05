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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CfsInsInfo : AbstractModel
    {
        
        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// User group ID
        /// </summary>
        [JsonProperty("UserGroupId")]
        public string UserGroupId{ get; set; }

        /// <summary>
        /// CFS instance ID
        /// </summary>
        [JsonProperty("CfsId")]
        public string CfsId{ get; set; }

        /// <summary>
        /// File system mount target ID
        /// </summary>
        [JsonProperty("MountInsId")]
        public string MountInsId{ get; set; }

        /// <summary>
        /// Local mount target
        /// </summary>
        [JsonProperty("LocalMountDir")]
        public string LocalMountDir{ get; set; }

        /// <summary>
        /// Remote mount target
        /// </summary>
        [JsonProperty("RemoteMountDir")]
        public string RemoteMountDir{ get; set; }

        /// <summary>
        /// File system IP
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IpAddress")]
        public string IpAddress{ get; set; }

        /// <summary>
        /// VPC ID of file system
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MountVpcId")]
        public string MountVpcId{ get; set; }

        /// <summary>
        /// VPC subnet ID of file system
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MountSubnetId")]
        public string MountSubnetId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserGroupId", this.UserGroupId);
            this.SetParamSimple(map, prefix + "CfsId", this.CfsId);
            this.SetParamSimple(map, prefix + "MountInsId", this.MountInsId);
            this.SetParamSimple(map, prefix + "LocalMountDir", this.LocalMountDir);
            this.SetParamSimple(map, prefix + "RemoteMountDir", this.RemoteMountDir);
            this.SetParamSimple(map, prefix + "IpAddress", this.IpAddress);
            this.SetParamSimple(map, prefix + "MountVpcId", this.MountVpcId);
            this.SetParamSimple(map, prefix + "MountSubnetId", this.MountSubnetId);
        }
    }
}

