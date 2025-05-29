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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetMsgRecordRequest : AbstractModel
    {
        
        /// <summary>
        /// Type.
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// Quantity.
        /// </summary>
        [JsonProperty("Count")]
        public ulong? Count{ get; set; }

        /// <summary>
        /// Session ID.
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// Application AppKey. When Type=5 [API Visitor], this field is required. </br> How to obtain it: </br> 1. After the application is released, obtain it at [Application Page]-[Release Management]-[Call Information]-[API Management]. </br> 2. Refer to item 2 in https://cloud.tencent.com/document/product/1759/109469.
        /// </summary>
        [JsonProperty("BotAppKey")]
        public string BotAppKey{ get; set; }

        /// <summary>
        /// Scenario, experience: 1; formal: 2.
        /// </summary>
        [JsonProperty("Scene")]
        public ulong? Scene{ get; set; }

        /// <summary>
        /// Last record ID. Retrieve messages in reverse order. You can only select either MidRecordId or LastRecordId.
        /// </summary>
        [JsonProperty("LastRecordId")]
        public string LastRecordId{ get; set; }

        /// <summary>
        /// If this value is input, it means pulling a total of count message records before and after the record ID. You can only select either MidRecordId or LastRecordId.
        /// </summary>
        [JsonProperty("MidRecordId")]
        public string MidRecordId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "BotAppKey", this.BotAppKey);
            this.SetParamSimple(map, prefix + "Scene", this.Scene);
            this.SetParamSimple(map, prefix + "LastRecordId", this.LastRecordId);
            this.SetParamSimple(map, prefix + "MidRecordId", this.MidRecordId);
        }
    }
}

