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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDspmExportTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Group account member id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>Risk level (0-Safe, 1-Low risk, 2-Medium-risk, 3-High-risk, -1-All)</p>
        /// </summary>
        [JsonProperty("DangerLevel")]
        public long? DangerLevel{ get; set; }

        /// <summary>
        /// <p>Database name</p>
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// <p>Database port</p>
        /// </summary>
        [JsonProperty("DbPort")]
        public long? DbPort{ get; set; }

        /// <summary>
        /// <p>Database IP</p>
        /// </summary>
        [JsonProperty("DbIp")]
        public string DbIp{ get; set; }

        /// <summary>
        /// <p>Asset ID.</p>
        /// </summary>
        [JsonProperty("AssetsId")]
        public long? AssetsId{ get; set; }

        /// <summary>
        /// <p>Session ID</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// <p>Client IP address</p>
        /// </summary>
        [JsonProperty("ClientSideIp")]
        public string ClientSideIp{ get; set; }

        /// <summary>
        /// <p>End time.</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// <p>Hit rule.</p>
        /// </summary>
        [JsonProperty("HitRule")]
        public long? HitRule{ get; set; }

        /// <summary>
        /// <p>Start time.</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// <p>Fuzzy query</p>
        /// </summary>
        [JsonProperty("FuzzySearch")]
        public string FuzzySearch{ get; set; }

        /// <summary>
        /// <p>Username.</p>
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// <p>Client</p>
        /// </summary>
        [JsonProperty("ClientName")]
        public string ClientName{ get; set; }

        /// <summary>
        /// <p>Traffic source. Parameter value: Agent/Proxy/empty. If Agent is passed, agent logs will be returned. If Proxy is passed, proxy logs will be returned. If both or neither are passed, return all.</p>
        /// </summary>
        [JsonProperty("SourceTypes")]
        public string[] SourceTypes{ get; set; }

        /// <summary>
        /// <p>Table name, length limited to 64. For multiple table name queries, use space-separated.</p>
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// <p>Field name, length limited to 64. For multiple field name queries, use space-separated.</p>
        /// </summary>
        [JsonProperty("FieldName")]
        public string FieldName{ get; set; }

        /// <summary>
        /// <p>Main SQL types: DDL, DML, DCL, TCL</p>
        /// </summary>
        [JsonProperty("SqlMainTypes")]
        public string[] SqlMainTypes{ get; set; }

        /// <summary>
        /// <p>Operation type</p>
        /// </summary>
        [JsonProperty("SqlType")]
        public string SqlType{ get; set; }

        /// <summary>
        /// <p>Minimum number of affected rows</p>
        /// </summary>
        [JsonProperty("RowNumMin")]
        public long? RowNumMin{ get; set; }

        /// <summary>
        /// <p>Maximum number of affected rows</p>
        /// </summary>
        [JsonProperty("RowNumMax")]
        public long? RowNumMax{ get; set; }

        /// <summary>
        /// <p>Database type</p>
        /// </summary>
        [JsonProperty("DbTypes")]
        public string[] DbTypes{ get; set; }

        /// <summary>
        /// <p>Response code</p>
        /// </summary>
        [JsonProperty("RetNo")]
        public long? RetNo{ get; set; }

        /// <summary>
        /// <p>Client tool</p>
        /// </summary>
        [JsonProperty("ClientDriverName")]
        public string ClientDriverName{ get; set; }

        /// <summary>
        /// <p>Client port</p>
        /// </summary>
        [JsonProperty("ClientPort")]
        public long? ClientPort{ get; set; }

        /// <summary>
        /// <p>Audit log ID.</p>
        /// </summary>
        [JsonProperty("LogId")]
        public string LogId{ get; set; }

        /// <summary>
        /// <p>Risk level array (0-secure, 1-low risk, 2-medium-risk, 3-high-risk). To select all, import all values. If empty, see the DangerLevel input parameter.</p>
        /// </summary>
        [JsonProperty("DangerLevels")]
        public long?[] DangerLevels{ get; set; }

        /// <summary>
        /// <p>Field classification</p>
        /// </summary>
        [JsonProperty("SensitiveCategoryRule")]
        public string SensitiveCategoryRule{ get; set; }

        /// <summary>
        /// <p>Field classification</p>
        /// </summary>
        [JsonProperty("SensitiveLevelRisk")]
        public string SensitiveLevelRisk{ get; set; }

        /// <summary>
        /// <p>Transaction Id.</p>
        /// </summary>
        [JsonProperty("TrxId")]
        public long? TrxId{ get; set; }

        /// <summary>
        /// <p>clientMac</p>
        /// </summary>
        [JsonProperty("ClientMac")]
        public string ClientMac{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamSimple(map, prefix + "DangerLevel", this.DangerLevel);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "DbPort", this.DbPort);
            this.SetParamSimple(map, prefix + "DbIp", this.DbIp);
            this.SetParamSimple(map, prefix + "AssetsId", this.AssetsId);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "ClientSideIp", this.ClientSideIp);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "HitRule", this.HitRule);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "FuzzySearch", this.FuzzySearch);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "ClientName", this.ClientName);
            this.SetParamArraySimple(map, prefix + "SourceTypes.", this.SourceTypes);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "FieldName", this.FieldName);
            this.SetParamArraySimple(map, prefix + "SqlMainTypes.", this.SqlMainTypes);
            this.SetParamSimple(map, prefix + "SqlType", this.SqlType);
            this.SetParamSimple(map, prefix + "RowNumMin", this.RowNumMin);
            this.SetParamSimple(map, prefix + "RowNumMax", this.RowNumMax);
            this.SetParamArraySimple(map, prefix + "DbTypes.", this.DbTypes);
            this.SetParamSimple(map, prefix + "RetNo", this.RetNo);
            this.SetParamSimple(map, prefix + "ClientDriverName", this.ClientDriverName);
            this.SetParamSimple(map, prefix + "ClientPort", this.ClientPort);
            this.SetParamSimple(map, prefix + "LogId", this.LogId);
            this.SetParamArraySimple(map, prefix + "DangerLevels.", this.DangerLevels);
            this.SetParamSimple(map, prefix + "SensitiveCategoryRule", this.SensitiveCategoryRule);
            this.SetParamSimple(map, prefix + "SensitiveLevelRisk", this.SensitiveLevelRisk);
            this.SetParamSimple(map, prefix + "TrxId", this.TrxId);
            this.SetParamSimple(map, prefix + "ClientMac", this.ClientMac);
        }
    }
}

