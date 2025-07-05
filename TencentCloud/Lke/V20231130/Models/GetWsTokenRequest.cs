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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetWsTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// Access type, 5 - API visitor .
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// Application AppKey</br>
        /// How to Obtain It:</br>
        /// 1. After the application is released, obtain it at [Release Management] - [Call Information] - [API Management] on the application page.</br>
        /// 2. See the second item in https://cloud.tencent.com/document/product/1759/109469.
        /// </summary>
        [JsonProperty("BotAppKey")]
        public string BotAppKey{ get; set; }

        /// <summary>
        /// Visitor ID (external input, recommended to be unique, identifies the user currently accessing the session). Length Limit: string(64).
        /// </summary>
        [JsonProperty("VisitorBizId")]
        public string VisitorBizId{ get; set; }

        /// <summary>
        /// Knowledge label, used for search filter in the knowledge base. This field is about to be deactivated. Please use the custom_variables field in the dialogue endpoint API to replace this field.
        /// </summary>
        [JsonProperty("VisitorLabels")]
        public GetWsTokenReq_Label[] VisitorLabels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "BotAppKey", this.BotAppKey);
            this.SetParamSimple(map, prefix + "VisitorBizId", this.VisitorBizId);
            this.SetParamArrayObj(map, prefix + "VisitorLabels.", this.VisitorLabels);
        }
    }
}

