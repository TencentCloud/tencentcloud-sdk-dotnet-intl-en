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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CheckIntlDomainNewResponse : AbstractModel
    {
        
        /// <summary>
        /// The name of the domain checked.
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// Whether the domain is available for registration.
        /// </summary>
        [JsonProperty("Available")]
        public bool? Available{ get; set; }

        /// <summary>
        /// The reason why the domain cannot be registered.
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }

        /// <summary>
        /// Whether the domain is a premium one.
        /// </summary>
        [JsonProperty("Premium")]
        public bool? Premium{ get; set; }

        /// <summary>
        /// The domain price.
        /// </summary>
        [JsonProperty("Price")]
        public float? Price{ get; set; }

        /// <summary>
        /// Whether the domain name involves restricted words.
        /// </summary>
        [JsonProperty("BlackWord")]
        public bool? BlackWord{ get; set; }

        /// <summary>
        /// The premium domain description.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Describe")]
        public string Describe{ get; set; }

        /// <summary>
        /// The price for renewing the premium domain.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FeeRenew")]
        public float? FeeRenew{ get; set; }

        /// <summary>
        /// The real price of the domain. For a premium domain, its price varies depending on the period. For a non-premium domain, the price is the 1-year price.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RealPrice")]
        public float? RealPrice{ get; set; }

        /// <summary>
        /// The price for transferring a premium domain in.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FeeTransfer")]
        public float? FeeTransfer{ get; set; }

        /// <summary>
        /// The price for redeeming a premium domain.
        /// </summary>
        [JsonProperty("FeeRestore")]
        public float? FeeRestore{ get; set; }

        /// <summary>
        /// The period (in years) of the domain.
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// The reason why the domain cannot be registered, expressed in Chinese.
        /// </summary>
        [JsonProperty("ReasonZh")]
        public string ReasonZh{ get; set; }

        /// <summary>
        /// The internal error code.
        /// </summary>
        [JsonProperty("ResCode")]
        public string ResCode{ get; set; }

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
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "Available", this.Available);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
            this.SetParamSimple(map, prefix + "Premium", this.Premium);
            this.SetParamSimple(map, prefix + "Price", this.Price);
            this.SetParamSimple(map, prefix + "BlackWord", this.BlackWord);
            this.SetParamSimple(map, prefix + "Describe", this.Describe);
            this.SetParamSimple(map, prefix + "FeeRenew", this.FeeRenew);
            this.SetParamSimple(map, prefix + "RealPrice", this.RealPrice);
            this.SetParamSimple(map, prefix + "FeeTransfer", this.FeeTransfer);
            this.SetParamSimple(map, prefix + "FeeRestore", this.FeeRestore);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "ReasonZh", this.ReasonZh);
            this.SetParamSimple(map, prefix + "ResCode", this.ResCode);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

