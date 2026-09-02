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

    public class AuditLogInfo : AbstractModel
    {
        
        /// <summary>
        /// AI score.
        /// </summary>
        [JsonProperty("AiScore")]
        public float? AiScore{ get; set; }

        /// <summary>
        /// Application user.
        /// </summary>
        [JsonProperty("AppUser")]
        public string AppUser{ get; set; }

        /// <summary>
        /// Backup data package.
        /// </summary>
        [JsonProperty("BackPacket")]
        public string BackPacket{ get; set; }

        /// <summary>
        /// Client IP
        /// </summary>
        [JsonProperty("ClientIp")]
        public string ClientIp{ get; set; }

        /// <summary>
        /// Client Mac.
        /// </summary>
        [JsonProperty("ClientMac")]
        public string ClientMac{ get; set; }

        /// <summary>
        /// Terminal name. When the value is Proxy, it indicates CASB proxy traffic. Otherwise, it indicates agent traffic.
        /// </summary>
        [JsonProperty("ClientName")]
        public string ClientName{ get; set; }

        /// <summary>
        /// Client user.
        /// </summary>
        [JsonProperty("ClientUser")]
        public string ClientUser{ get; set; }

        /// <summary>
        /// Client port
        /// </summary>
        [JsonProperty("ClientPort")]
        public ulong? ClientPort{ get; set; }

        /// <summary>
        /// Risk level
        /// </summary>
        [JsonProperty("DangerLevel")]
        public ulong? DangerLevel{ get; set; }

        /// <summary>
        /// Database IP.
        /// </summary>
        [JsonProperty("DbIp")]
        public string DbIp{ get; set; }

        /// <summary>
        /// Database name.
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// Database port.
        /// </summary>
        [JsonProperty("DbPort")]
        public ulong? DbPort{ get; set; }

        /// <summary>
        /// Database user
        /// </summary>
        [JsonProperty("DbUser")]
        public string DbUser{ get; set; }

        /// <summary>
        /// Number of affected rows
        /// </summary>
        [JsonProperty("EffectRow")]
        public ulong? EffectRow{ get; set; }

        /// <summary>
        /// Execution time, unit: ms
        /// </summary>
        [JsonProperty("ExecTime")]
        public ulong? ExecTime{ get; set; }

        /// <summary>
        /// Matched rule
        /// </summary>
        [JsonProperty("HitRule")]
        public string HitRule{ get; set; }

        /// <summary>
        /// Log ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// Data asset name
        /// </summary>
        [JsonProperty("InstanceId")]
        public ulong? InstanceId{ get; set; }

        /// <summary>
        /// Audit unit name.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Operational statement (SQL statement).
        /// </summary>
        [JsonProperty("OpSql")]
        public string OpSql{ get; set; }

        /// <summary>
        /// Operation time (time).
        /// </summary>
        [JsonProperty("OpTime")]
        public ulong? OpTime{ get; set; }

        /// <summary>
        /// message
        /// </summary>
        [JsonProperty("RetMsg")]
        public string RetMsg{ get; set; }

        /// <summary>
        /// code
        /// </summary>
        [JsonProperty("RetNo")]
        public ulong? RetNo{ get; set; }

        /// <summary>
        /// Session ID
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// Operation type.
        /// </summary>
        [JsonProperty("SqlType")]
        public string SqlType{ get; set; }

        /// <summary>
        /// Table name
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// Data asset name
        /// </summary>
        [JsonProperty("AssetName")]
        public string AssetName{ get; set; }

        /// <summary>
        /// Rule set.
        /// </summary>
        [JsonProperty("HitRules")]
        public HitRules[] HitRules{ get; set; }

        /// <summary>
        /// Traffic source
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// Single audit log ID.
        /// </summary>
        [JsonProperty("ReqId")]
        public string ReqId{ get; set; }

        /// <summary>
        /// Main SQL types: DML, DDL, DCL, and TCL.
        /// </summary>
        [JsonProperty("SqlMainType")]
        public string SqlMainType{ get; set; }

        /// <summary>
        /// Table name collection.
        /// </summary>
        [JsonProperty("TableNames")]
        public string[] TableNames{ get; set; }

        /// <summary>
        /// Field name collection
        /// </summary>
        [JsonProperty("FieldNames")]
        public string[] FieldNames{ get; set; }

        /// <summary>
        /// Field name
        /// </summary>
        [JsonProperty("FieldName")]
        public string FieldName{ get; set; }

        /// <summary>
        /// Database type
        /// </summary>
        [JsonProperty("DbType")]
        public string DbType{ get; set; }

        /// <summary>
        /// Client tool.
        /// </summary>
        [JsonProperty("ClientDriverName")]
        public string ClientDriverName{ get; set; }

        /// <summary>
        /// Location information
        /// </summary>
        [JsonProperty("Location")]
        public Location Location{ get; set; }

        /// <summary>
        /// Field information (contains sensitive information).
        /// </summary>
        [JsonProperty("FieldDetails")]
        public TableField[] FieldDetails{ get; set; }

        /// <summary>
        /// app id of the account that owns the asset
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// Account nickname
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// Account uin of the asset owner
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AiScore", this.AiScore);
            this.SetParamSimple(map, prefix + "AppUser", this.AppUser);
            this.SetParamSimple(map, prefix + "BackPacket", this.BackPacket);
            this.SetParamSimple(map, prefix + "ClientIp", this.ClientIp);
            this.SetParamSimple(map, prefix + "ClientMac", this.ClientMac);
            this.SetParamSimple(map, prefix + "ClientName", this.ClientName);
            this.SetParamSimple(map, prefix + "ClientUser", this.ClientUser);
            this.SetParamSimple(map, prefix + "ClientPort", this.ClientPort);
            this.SetParamSimple(map, prefix + "DangerLevel", this.DangerLevel);
            this.SetParamSimple(map, prefix + "DbIp", this.DbIp);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "DbPort", this.DbPort);
            this.SetParamSimple(map, prefix + "DbUser", this.DbUser);
            this.SetParamSimple(map, prefix + "EffectRow", this.EffectRow);
            this.SetParamSimple(map, prefix + "ExecTime", this.ExecTime);
            this.SetParamSimple(map, prefix + "HitRule", this.HitRule);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "OpSql", this.OpSql);
            this.SetParamSimple(map, prefix + "OpTime", this.OpTime);
            this.SetParamSimple(map, prefix + "RetMsg", this.RetMsg);
            this.SetParamSimple(map, prefix + "RetNo", this.RetNo);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SqlType", this.SqlType);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamArrayObj(map, prefix + "HitRules.", this.HitRules);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "ReqId", this.ReqId);
            this.SetParamSimple(map, prefix + "SqlMainType", this.SqlMainType);
            this.SetParamArraySimple(map, prefix + "TableNames.", this.TableNames);
            this.SetParamArraySimple(map, prefix + "FieldNames.", this.FieldNames);
            this.SetParamSimple(map, prefix + "FieldName", this.FieldName);
            this.SetParamSimple(map, prefix + "DbType", this.DbType);
            this.SetParamSimple(map, prefix + "ClientDriverName", this.ClientDriverName);
            this.SetParamObj(map, prefix + "Location.", this.Location);
            this.SetParamArrayObj(map, prefix + "FieldDetails.", this.FieldDetails);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
        }
    }
}

