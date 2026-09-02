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

    public class UserItem : AbstractModel
    {
        
        /// <summary>
        /// <p>Login user appid</p>
        /// </summary>
        [JsonProperty("AppID")]
        public ulong? AppID{ get; set; }

        /// <summary>
        /// <p>Type of user</p>
        /// </summary>
        [JsonProperty("AccountType")]
        public ulong? AccountType{ get; set; }

        /// <summary>
        /// <p>User payment mode</p>
        /// </summary>
        [JsonProperty("PayType")]
        public ulong? PayType{ get; set; }

        /// <summary>
        /// <p>Total quota count</p>
        /// </summary>
        [JsonProperty("TotalQuota")]
        public ulong? TotalQuota{ get; set; }

        /// <summary>
        /// <p>Consumed quota count</p>
        /// </summary>
        [JsonProperty("CostQuota")]
        public ulong? CostQuota{ get; set; }

        /// <summary>
        /// <p>Cloud vendor information</p>
        /// </summary>
        [JsonProperty("Providers")]
        public string[] Providers{ get; set; }

        /// <summary>
        /// <p>refresh: update next time; expire: no longer update next time</p>
        /// </summary>
        [JsonProperty("QuotaFlushType")]
        public string QuotaFlushType{ get; set; }

        /// <summary>
        /// <p>Next quota refresh time</p>
        /// </summary>
        [JsonProperty("QuotaFlushTime")]
        public string QuotaFlushTime{ get; set; }

        /// <summary>
        /// <p>Purchase type</p>
        /// </summary>
        [JsonProperty("QuotaSource")]
        public ulong? QuotaSource{ get; set; }

        /// <summary>
        /// <p>The appid of the sharing party when shared, or 0 when purchased or out of quota</p>
        /// </summary>
        [JsonProperty("ShareFromAppID")]
        public ulong? ShareFromAppID{ get; set; }

        /// <summary>
        /// <p>Quota sharing party account</p>
        /// </summary>
        [JsonProperty("ShareFromUser")]
        public string ShareFromUser{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "AccountType", this.AccountType);
            this.SetParamSimple(map, prefix + "PayType", this.PayType);
            this.SetParamSimple(map, prefix + "TotalQuota", this.TotalQuota);
            this.SetParamSimple(map, prefix + "CostQuota", this.CostQuota);
            this.SetParamArraySimple(map, prefix + "Providers.", this.Providers);
            this.SetParamSimple(map, prefix + "QuotaFlushType", this.QuotaFlushType);
            this.SetParamSimple(map, prefix + "QuotaFlushTime", this.QuotaFlushTime);
            this.SetParamSimple(map, prefix + "QuotaSource", this.QuotaSource);
            this.SetParamSimple(map, prefix + "ShareFromAppID", this.ShareFromAppID);
            this.SetParamSimple(map, prefix + "ShareFromUser", this.ShareFromUser);
        }
    }
}

