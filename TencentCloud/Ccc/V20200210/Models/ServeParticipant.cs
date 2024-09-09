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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServeParticipant : AbstractModel
    {
        
        /// <summary>
        /// Agent email.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Mail")]
        public string Mail{ get; set; }

        /// <summary>
        /// Agent Telephone
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone{ get; set; }

        /// <summary>
        /// Ring timestamp. Unix second-level timestamp.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RingTimestamp")]
        public long? RingTimestamp{ get; set; }

        /// <summary>
        /// Answer timestamp. Unix second-level timestamp.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AcceptTimestamp")]
        public long? AcceptTimestamp{ get; set; }

        /// <summary>
        /// End timestamp. Unix second-level timestamp.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EndedTimestamp")]
        public long? EndedTimestamp{ get; set; }

        /// <summary>
        /// Recording ID, which can be used to index the recording on the agent side
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// Participant type: "staffSeat", "outboundSeat", "staffPhoneSeat".
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Transfer Source Agent Information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TransferFrom")]
        public string TransferFrom{ get; set; }

        /// <summary>
        /// Transfer source participant type is consistent with the Type value.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TransferFromType")]
        public string TransferFromType{ get; set; }

        /// <summary>
        /// Transfer Destination Agent Information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TransferTo")]
        public string TransferTo{ get; set; }

        /// <summary>
        /// Transfer destination participant type is consistent with Type values.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TransferToType")]
        public string TransferToType{ get; set; }

        /// <summary>
        /// Skill group ID.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SkillGroupId")]
        public long? SkillGroupId{ get; set; }

        /// <summary>
        /// Ending status.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EndStatusString")]
        public string EndStatusString{ get; set; }

        /// <summary>
        /// Recording URL.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RecordURL")]
        public string RecordURL{ get; set; }

        /// <summary>
        /// Participant sequence number, starting from 0.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Sequence")]
        public long? Sequence{ get; set; }

        /// <summary>
        /// Start timestamp. Unix second-level timestamp.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StartTimestamp")]
        public long? StartTimestamp{ get; set; }

        /// <summary>
        /// Skill Group name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SkillGroupName")]
        public string SkillGroupName{ get; set; }

        /// <summary>
        /// Address of the third party COS for transferring recording.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CustomRecordURL")]
        public string CustomRecordURL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mail", this.Mail);
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamSimple(map, prefix + "RingTimestamp", this.RingTimestamp);
            this.SetParamSimple(map, prefix + "AcceptTimestamp", this.AcceptTimestamp);
            this.SetParamSimple(map, prefix + "EndedTimestamp", this.EndedTimestamp);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "TransferFrom", this.TransferFrom);
            this.SetParamSimple(map, prefix + "TransferFromType", this.TransferFromType);
            this.SetParamSimple(map, prefix + "TransferTo", this.TransferTo);
            this.SetParamSimple(map, prefix + "TransferToType", this.TransferToType);
            this.SetParamSimple(map, prefix + "SkillGroupId", this.SkillGroupId);
            this.SetParamSimple(map, prefix + "EndStatusString", this.EndStatusString);
            this.SetParamSimple(map, prefix + "RecordURL", this.RecordURL);
            this.SetParamSimple(map, prefix + "Sequence", this.Sequence);
            this.SetParamSimple(map, prefix + "StartTimestamp", this.StartTimestamp);
            this.SetParamSimple(map, prefix + "SkillGroupName", this.SkillGroupName);
            this.SetParamSimple(map, prefix + "CustomRecordURL", this.CustomRecordURL);
        }
    }
}

