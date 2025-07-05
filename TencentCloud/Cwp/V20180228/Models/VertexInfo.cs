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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VertexInfo : AbstractModel
    {
        
        /// <summary>
        /// Node type: process: 1; network: 2; file: 3; ssh: 4;
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// VID contained in this node
        /// </summary>
        [JsonProperty("Vid")]
        public string Vid{ get; set; }

        /// <summary>
        /// Parent node VID of this node
        /// </summary>
        [JsonProperty("ParentVid")]
        public string ParentVid{ get; set; }

        /// <summary>
        /// Whether a leaf node
        /// </summary>
        [JsonProperty("IsLeaf")]
        public bool? IsLeaf{ get; set; }

        /// <summary>
        /// Process name, used when Type=1
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProcNamePrefix")]
        public string ProcNamePrefix{ get; set; }

        /// <summary>
        /// Process name MD5, used when Type=1
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProcNameMd5")]
        public string ProcNameMd5{ get; set; }

        /// <summary>
        /// Command line, used when Type=1
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CmdLinePrefix")]
        public string CmdLinePrefix{ get; set; }

        /// <summary>
        /// Command line MD5, used when Type=1
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CmdLineMd5")]
        public string CmdLineMd5{ get; set; }

        /// <summary>
        /// File path, used when Type=3
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FilePathPrefix")]
        public string FilePathPrefix{ get; set; }

        /// <summary>
        /// Request destination address, used when Type=2
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AddressPrefix")]
        public string AddressPrefix{ get; set; }

        /// <summary>
        /// Whether a vulnerability node
        /// </summary>
        [JsonProperty("IsWeDetect")]
        public bool? IsWeDetect{ get; set; }

        /// <summary>
        /// Whether an alarm node
        /// </summary>
        [JsonProperty("IsAlarm")]
        public bool? IsAlarm{ get; set; }

        /// <summary>
        /// File path MD5, used when Type=3
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FilePathMd5")]
        public string FilePathMd5{ get; set; }

        /// <summary>
        /// Request destination address MD5, used when Type=2
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AddressMd5")]
        public string AddressMd5{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Vid", this.Vid);
            this.SetParamSimple(map, prefix + "ParentVid", this.ParentVid);
            this.SetParamSimple(map, prefix + "IsLeaf", this.IsLeaf);
            this.SetParamSimple(map, prefix + "ProcNamePrefix", this.ProcNamePrefix);
            this.SetParamSimple(map, prefix + "ProcNameMd5", this.ProcNameMd5);
            this.SetParamSimple(map, prefix + "CmdLinePrefix", this.CmdLinePrefix);
            this.SetParamSimple(map, prefix + "CmdLineMd5", this.CmdLineMd5);
            this.SetParamSimple(map, prefix + "FilePathPrefix", this.FilePathPrefix);
            this.SetParamSimple(map, prefix + "AddressPrefix", this.AddressPrefix);
            this.SetParamSimple(map, prefix + "IsWeDetect", this.IsWeDetect);
            this.SetParamSimple(map, prefix + "IsAlarm", this.IsAlarm);
            this.SetParamSimple(map, prefix + "FilePathMd5", this.FilePathMd5);
            this.SetParamSimple(map, prefix + "AddressMd5", this.AddressMd5);
        }
    }
}

