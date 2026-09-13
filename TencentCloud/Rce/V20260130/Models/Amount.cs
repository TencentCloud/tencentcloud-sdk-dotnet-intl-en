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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Amount : AbstractModel
    {
        
        /// <summary>
        /// <p>Currency code</p><p>Parameter format: Compliant with the ISO 4217 standard</p>
        /// </summary>
        [JsonProperty("Currency")]
        public string Currency{ get; set; }

        /// <summary>
        /// <p>Original amount in currency</p>
        /// </summary>
        [JsonProperty("OriginalAmount")]
        public float? OriginalAmount{ get; set; }

        /// <summary>
        /// <p>Current exchange rate of base currency converted to USD</p>
        /// </summary>
        [JsonProperty("ExchangeRateUSD")]
        public float? ExchangeRateUSD{ get; set; }

        /// <summary>
        /// <p>Current exchange rate of base currency converted to CNY</p>
        /// </summary>
        [JsonProperty("ExchangeRateCNY")]
        public float? ExchangeRateCNY{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Currency", this.Currency);
            this.SetParamSimple(map, prefix + "OriginalAmount", this.OriginalAmount);
            this.SetParamSimple(map, prefix + "ExchangeRateUSD", this.ExchangeRateUSD);
            this.SetParamSimple(map, prefix + "ExchangeRateCNY", this.ExchangeRateCNY);
        }
    }
}

