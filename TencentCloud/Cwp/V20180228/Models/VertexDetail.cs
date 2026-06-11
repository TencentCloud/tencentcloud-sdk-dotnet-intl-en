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

    public class VertexDetail : AbstractModel
    {
        
        /// <summary>
        /// Node type. 1: process, 2: network, 3: file, 4: SSH.
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// Time used by each node type, in the format of 2022-11-29 00:00:00.
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// Alarm information.
        /// </summary>
        [JsonProperty("AlarmInfo")]
        public AlarmInfo[] AlarmInfo{ get; set; }

        /// <summary>
        /// Process name. This parameter takes effect when this node is a process.
        /// </summary>
        [JsonProperty("ProcName")]
        public string ProcName{ get; set; }

        /// <summary>
        /// Command line. This parameter takes effect when this node is a process.
        /// </summary>
        [JsonProperty("CmdLine")]
        public string CmdLine{ get; set; }

        /// <summary>
        /// Process ID. This parameter takes effect when this node is a process.
        /// </summary>
        [JsonProperty("Pid")]
        public string Pid{ get; set; }

        /// <summary>
        /// File MD5. This parameter takes effect when this node is a file.
        /// </summary>
        [JsonProperty("FileMd5")]
        public string FileMd5{ get; set; }

        /// <summary>
        /// File write content. This parameter takes effect when this node is a file.
        /// </summary>
        [JsonProperty("FileContent")]
        public string FileContent{ get; set; }

        /// <summary>
        /// File path. This parameter takes effect when this node is a file.
        /// </summary>
        [JsonProperty("FilePath")]
        public string FilePath{ get; set; }

        /// <summary>
        /// File creation time. This parameter takes effect when this node is a file.
        /// </summary>
        [JsonProperty("FileCreateTime")]
        public string FileCreateTime{ get; set; }

        /// <summary>
        /// Request destination address. This parameter takes effect when this node is a network.
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// Target port. This parameter takes effect when this node is a network.
        /// </summary>
        [JsonProperty("DstPort")]
        public ulong? DstPort{ get; set; }

        /// <summary>
        /// Login source IP address. This parameter takes effect when this node is ssh.
        /// </summary>
        [JsonProperty("SrcIP")]
        public string SrcIP{ get; set; }

        /// <summary>
        /// Login username and user group. This parameter takes effect when this node is ssh.
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// Vulnerability name. This parameter takes effect when this node is a vulnerability.
        /// </summary>
        [JsonProperty("VulName")]
        public string VulName{ get; set; }

        /// <summary>
        /// Vulnerability exploitation time. This parameter takes effect when this node is a vulnerability.
        /// </summary>
        [JsonProperty("VulTime")]
        public string VulTime{ get; set; }

        /// <summary>
        /// HTTP request content. This parameter takes effect when this node is a vulnerability.
        /// </summary>
        [JsonProperty("HttpContent")]
        public string HttpContent{ get; set; }

        /// <summary>
        /// Source IP address of the vulnerability exploiter. This parameter takes effect when this node is a vulnerability.
        /// </summary>
        [JsonProperty("VulSrcIP")]
        public string VulSrcIP{ get; set; }

        /// <summary>
        /// Node ID.
        /// </summary>
        [JsonProperty("VertexId")]
        public string VertexId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamArrayObj(map, prefix + "AlarmInfo.", this.AlarmInfo);
            this.SetParamSimple(map, prefix + "ProcName", this.ProcName);
            this.SetParamSimple(map, prefix + "CmdLine", this.CmdLine);
            this.SetParamSimple(map, prefix + "Pid", this.Pid);
            this.SetParamSimple(map, prefix + "FileMd5", this.FileMd5);
            this.SetParamSimple(map, prefix + "FileContent", this.FileContent);
            this.SetParamSimple(map, prefix + "FilePath", this.FilePath);
            this.SetParamSimple(map, prefix + "FileCreateTime", this.FileCreateTime);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "DstPort", this.DstPort);
            this.SetParamSimple(map, prefix + "SrcIP", this.SrcIP);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "VulName", this.VulName);
            this.SetParamSimple(map, prefix + "VulTime", this.VulTime);
            this.SetParamSimple(map, prefix + "HttpContent", this.HttpContent);
            this.SetParamSimple(map, prefix + "VulSrcIP", this.VulSrcIP);
            this.SetParamSimple(map, prefix + "VertexId", this.VertexId);
        }
    }
}

