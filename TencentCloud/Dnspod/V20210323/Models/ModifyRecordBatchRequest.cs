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

namespace TencentCloud.Dnspod.V20210323.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyRecordBatchRequest : AbstractModel
    {
        
        /// <summary>
        /// Array of record IDs. You can view all DNS records and their IDs via the `DescribeRecordList` API.
        /// </summary>
        [JsonProperty("RecordIdList")]
        public ulong?[] RecordIdList{ get; set; }

        /// <summary>
        /// The field to be modified. Valid values: `sub_domain`, `record_type`, `area`, `value`, `mx`, `ttl`, `status`.
        /// </summary>
        [JsonProperty("Change")]
        public string Change{ get; set; }

        /// <summary>
        /// The value to be changed to, which is required and subject to the `change` field.
        /// </summary>
        [JsonProperty("ChangeTo")]
        public string ChangeTo{ get; set; }

        /// <summary>
        /// The record value to be changed to, which is required only if the `change` field is `record_type`.
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// MX record priority, which is required only if the `Change` field is `mx`.
        /// </summary>
        [JsonProperty("MX")]
        public string MX{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "RecordIdList.", this.RecordIdList);
            this.SetParamSimple(map, prefix + "Change", this.Change);
            this.SetParamSimple(map, prefix + "ChangeTo", this.ChangeTo);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "MX", this.MX);
        }
    }
}

