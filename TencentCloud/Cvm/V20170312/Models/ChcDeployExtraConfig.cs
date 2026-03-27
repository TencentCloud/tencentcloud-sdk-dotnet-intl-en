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

    public class ChcDeployExtraConfig : AbstractModel
    {
        
        /// <summary>
        /// MinIO type: whether to use Tencent Cloud's minios or the customer's own minios.
        /// </summary>
        [JsonProperty("MiniOsType")]
        public string MiniOsType{ get; set; }

        /// <summary>
        /// Server architecture and boot mode. Value: x86_legacy, arm_uefi.
        /// </summary>
        [JsonProperty("BootType")]
        public string BootType{ get; set; }

        /// <summary>
        /// The boot file used by PXE. Default: pxelinux.0.
        /// </summary>
        [JsonProperty("BootFile")]
        public string BootFile{ get; set; }

        /// <summary>
        /// tftp server ip address.
        /// </summary>
        [JsonProperty("NextServerAddress")]
        public string NextServerAddress{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MiniOsType", this.MiniOsType);
            this.SetParamSimple(map, prefix + "BootType", this.BootType);
            this.SetParamSimple(map, prefix + "BootFile", this.BootFile);
            this.SetParamSimple(map, prefix + "NextServerAddress", this.NextServerAddress);
        }
    }
}

