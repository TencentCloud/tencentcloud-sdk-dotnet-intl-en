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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConversationRecordSummary : AbstractModel
    {
        
        /// <summary>
        /// <p>Reply record ID, corresponding to the record_id of the reply message in messages</p>
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// <p>ID of the user's question record, corresponding to the record_id of the user message in messages</p>
        /// </summary>
        [JsonProperty("RelatedRecordId")]
        public string RelatedRecordId{ get; set; }

        /// <summary>
        /// <p>Duration info of a single dialogue</p>
        /// </summary>
        [JsonProperty("TimeUsage")]
        public ConversationRecordTimeUsage TimeUsage{ get; set; }

        /// <summary>
        /// <p>token consumption information of a single dialogue</p>
        /// </summary>
        [JsonProperty("TokenUsage")]
        public ConversationRecordTokenUsage TokenUsage{ get; set; }

        /// <summary>
        /// <p>Description of a single dialogue failure; empty if successful</p>
        /// </summary>
        [JsonProperty("ErrorInfo")]
        public ConversationRecordErrorInfo ErrorInfo{ get; set; }

        /// <summary>
        /// <p>Status of a single employee assistant dialogue.</p><p>Enumeration values: </p><ul><li>pending: Pending, </li><li>processing: Processing, </li><li>success: Success, </li><li>failed: Failure, </li><li>stop: Stopped.</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "RelatedRecordId", this.RelatedRecordId);
            this.SetParamObj(map, prefix + "TimeUsage.", this.TimeUsage);
            this.SetParamObj(map, prefix + "TokenUsage.", this.TokenUsage);
            this.SetParamObj(map, prefix + "ErrorInfo.", this.ErrorInfo);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

