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

    public class AlertInfo : AbstractModel
    {
        
        /// <summary>
        /// alarm ID
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }

        /// <summary>
        /// alarm name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Alarm source
        /// CFW: Cloud Firewall
        /// WAF: Web application firewall
        /// CWP: Host Security
        /// CSIP: Cloud Security Center
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// alarm level
        /// Prompt.
        /// 2: Low risk
        /// 3: Medium risk
        /// 4: High risk
        /// 5: Critical
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// attacker
        /// </summary>
        [JsonProperty("Attacker")]
        public RoleInfo Attacker{ get; set; }

        /// <summary>
        /// victim
        /// </summary>
        [JsonProperty("Victim")]
        public RoleInfo Victim{ get; set; }

        /// <summary>
        /// Evidence data (such as attack content, base64 encoded)
        /// </summary>
        [JsonProperty("EvidenceData")]
        public string EvidenceData{ get; set; }

        /// <summary>
        /// evidence location (for example protocol port)
        /// </summary>
        [JsonProperty("EvidenceLocation")]
        public string EvidenceLocation{ get; set; }

        /// <summary>
        /// Evidence Path
        /// </summary>
        [JsonProperty("EvidencePath")]
        public string EvidencePath{ get; set; }

        /// <summary>
        /// Initial alarm time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Latest Alarm Time
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Alarm count
        /// </summary>
        [JsonProperty("Count")]
        public ulong? Count{ get; set; }

        /// <summary>
        /// Emergency Mitigation Suggestions
        /// </summary>
        [JsonProperty("UrgentSuggestion")]
        public string UrgentSuggestion{ get; set; }

        /// <summary>
        /// Radical Treatment Suggestion
        /// </summary>
        [JsonProperty("RemediationSuggestion")]
        public string RemediationSuggestion{ get; set; }

        /// <summary>
        /// Processing status
        /// 0: unprocessed, 1: ignored, 2: processed
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Alarm Handling Type
        /// </summary>
        [JsonProperty("ProcessType")]
        public string ProcessType{ get; set; }

        /// <summary>
        /// Major Category of Alarm
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Alarm Subcategory
        /// </summary>
        [JsonProperty("SubType")]
        public string SubType{ get; set; }

        /// <summary>
        /// Dropdown Field
        /// </summary>
        [JsonProperty("ExtraInfo")]
        public AlertExtraInfo ExtraInfo{ get; set; }

        /// <summary>
        /// Aggregate Fields
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// Alarm Date
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// appid
        /// </summary>
        [JsonProperty("AppID")]
        public string AppID{ get; set; }

        /// <summary>
        /// Account name
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// account ID
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// Behavior
        /// </summary>
        [JsonProperty("Action")]
        public ulong? Action{ get; set; }

        /// <summary>
        /// risk detection
        /// </summary>
        [JsonProperty("RiskInvestigation")]
        public string RiskInvestigation{ get; set; }

        /// <summary>
        /// Risk handling
        /// </summary>
        [JsonProperty("RiskTreatment")]
        public string RiskTreatment{ get; set; }

        /// <summary>
        /// log type
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// Statement retrieval
        /// </summary>
        [JsonProperty("LogSearch")]
        public string LogSearch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamObj(map, prefix + "Attacker.", this.Attacker);
            this.SetParamObj(map, prefix + "Victim.", this.Victim);
            this.SetParamSimple(map, prefix + "EvidenceData", this.EvidenceData);
            this.SetParamSimple(map, prefix + "EvidenceLocation", this.EvidenceLocation);
            this.SetParamSimple(map, prefix + "EvidencePath", this.EvidencePath);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "UrgentSuggestion", this.UrgentSuggestion);
            this.SetParamSimple(map, prefix + "RemediationSuggestion", this.RemediationSuggestion);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ProcessType", this.ProcessType);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "SubType", this.SubType);
            this.SetParamObj(map, prefix + "ExtraInfo.", this.ExtraInfo);
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "RiskInvestigation", this.RiskInvestigation);
            this.SetParamSimple(map, prefix + "RiskTreatment", this.RiskTreatment);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "LogSearch", this.LogSearch);
        }
    }
}

