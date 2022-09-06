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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetSdkVerificationResultResponse : AbstractModel
    {
        
        /// <summary>
        /// The result of the entire verification process.
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// The result description.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// The charge count.
        /// </summary>
        [JsonProperty("ChargeCount")]
        public long? ChargeCount{ get; set; }

        /// <summary>
        /// The results of multiple OCR processes (in order). The result of the final process is taken as the valid result.
        /// </summary>
        [JsonProperty("CardVerifyResults")]
        public CardVerifyResult[] CardVerifyResults{ get; set; }

        /// <summary>
        /// The results of multiple liveness detection processes (in order). The result of the final process is taken as the valid result.
        /// </summary>
        [JsonProperty("CompareResults")]
        public CompareResult[] CompareResults{ get; set; }

        /// <summary>
        /// Info passed in the process of getting the token.
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ChargeCount", this.ChargeCount);
            this.SetParamArrayObj(map, prefix + "CardVerifyResults.", this.CardVerifyResults);
            this.SetParamArrayObj(map, prefix + "CompareResults.", this.CompareResults);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

