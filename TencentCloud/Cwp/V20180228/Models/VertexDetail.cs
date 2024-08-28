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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VertexDetail : AbstractModel
    {
        
        /// <summary>
        /// Node type. process - 1; network - 2; file - 3; SSH - 4
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// Time used for each node type, which is in the format of 2022-11-29 00:00:00.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// Alarm information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AlarmInfo")]
        public AlarmInfo[] AlarmInfo{ get; set; }

        /// <summary>
        /// Process name, which is effective when the node type is process.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProcName")]
        public string ProcName{ get; set; }

        /// <summary>
        /// Command line, which is effective when the node type is process.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CmdLine")]
        public string CmdLine{ get; set; }

        /// <summary>
        /// Process ID, which is effective when the node type is process.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Pid")]
        public string Pid{ get; set; }

        /// <summary>
        /// File MD5, which is effective when the node type is file.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FileMd5")]
        public string FileMd5{ get; set; }

        /// <summary>
        /// Content written to the file, which is effective when the node type is file.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FileContent")]
        public string FileContent{ get; set; }

        /// <summary>
        /// File path, which is effective when the node type is file.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FilePath")]
        public string FilePath{ get; set; }

        /// <summary>
        /// File creation time, which is effective when the node type is file.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FileCreateTime")]
        public string FileCreateTime{ get; set; }

        /// <summary>
        /// Request destination address, which is effective when the node type is network.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// Target port, which is effective when the node type is network.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DstPort")]
        public ulong? DstPort{ get; set; }

        /// <summary>
        /// Log-in source IP, which is effective when the node type is SSH.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SrcIP")]
        public string SrcIP{ get; set; }

        /// <summary>
        /// Log-in username and user group, which is effective when the node type is SSH.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// Vulnerability name, which is effective when the node type is vulnerability.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VulName")]
        public string VulName{ get; set; }

        /// <summary>
        /// Vulnerability exploitation time, which is effective when the node type is vulnerability.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VulTime")]
        public string VulTime{ get; set; }

        /// <summary>
        /// HTTP request content, which is effective when the node type is vulnerability.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HttpContent")]
        public string HttpContent{ get; set; }

        /// <summary>
        /// Vulnerability exploiter source IP, which is effective when the node type is vulnerability.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VulSrcIP")]
        public string VulSrcIP{ get; set; }

        /// <summary>
        /// Node ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
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

