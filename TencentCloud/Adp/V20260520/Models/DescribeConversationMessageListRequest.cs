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

    public class DescribeConversationMessageListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Session ID.</p>
        /// </summary>
        [JsonProperty("ConversationId")]
        public string ConversationId{ get; set; }

        /// <summary>
        /// <p>Session type enumeration values: 0-CONVERSATION_TYPE_UNSPECIFIED (unspecified; means all in list query), 1-CONVERSATION_TYPE_VISITOR (visitor trial), 2-CONVERSATION_TYPE_EVALUATION (evaluation), 5-CONVERSATION_TYPE_API (API integration), 10-CONVERSATION_TYPE_WORKFLOW (workflow debugging), 20-CONVERSATION_TYPE_SHARE (share link)</p>
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// <p>Required when Type=CONVERSATION_TYPE_API. Application key</p>
        /// </summary>
        [JsonProperty("AppKey")]
        public string AppKey{ get; set; }

        /// <summary>
        /// <p>Total number of returned records. Default: 10. Maximum: 50. When querying forward or backward, messages of the record specified by record_id are excluded. When querying from the center in both directions, the message of the record specified by record_id is included. The number of returned records is limit / 2 for each direction, rounded up.</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>Sub-user Uin.</p>
        /// </summary>
        [JsonProperty("LoginSubAccountUin")]
        public string LoginSubAccountUin{ get; set; }

        /// <summary>
        /// <p>Root user Uin.</p>
        /// </summary>
        [JsonProperty("LoginUin")]
        public string LoginUin{ get; set; }

        /// <summary>
        /// <p>Query anchor record ID</p>
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// <p>Query direction relative to record_id. Enumeration values: 0-RECORD_QUERY_DIRECTION_UNSPECIFIED (not specified, compatible with legacy logic, query forward by default), 1-RECORD_QUERY_DIRECTION_BACKWARD (query earlier messages forward from record_id), 2-RECORD_QUERY_DIRECTION_FORWARD (query newer messages backward from record_id), 3-RECORD_QUERY_DIRECTION_BIDIRECTIONAL (query both forward and backward from record_id as the center)</p>
        /// </summary>
        [JsonProperty("RecordQueryDirection")]
        public long? RecordQueryDirection{ get; set; }

        /// <summary>
        /// <p>Required when Type is CONVERSATION_TYPE_SHARE. Share code</p>
        /// </summary>
        [JsonProperty("ShareCode")]
        public string ShareCode{ get; set; }

        /// <summary>
        /// <p>Required when Type=CONVERSATION_TYPE_API. Visitor ID</p>
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConversationId", this.ConversationId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "AppKey", this.AppKey);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "LoginSubAccountUin", this.LoginSubAccountUin);
            this.SetParamSimple(map, prefix + "LoginUin", this.LoginUin);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "RecordQueryDirection", this.RecordQueryDirection);
            this.SetParamSimple(map, prefix + "ShareCode", this.ShareCode);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
        }
    }
}

