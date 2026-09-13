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

    public class Wallet : AbstractModel
    {
        
        /// <summary>
        /// <p>Wallet type</p><p>Enumeration value:</p><ul><li>crypto: Crypto currency</li><li>digital: Digital currency</li><li>fiat: Fiat currency</li></ul>
        /// </summary>
        [JsonProperty("WalletType")]
        public string WalletType{ get; set; }

        /// <summary>
        /// <p>The address of the wallet.Usually it is the ID of the wallet.</p>
        /// </summary>
        [JsonProperty("WalletAddress")]
        public string WalletAddress{ get; set; }

        /// <summary>
        /// <p>The full name of the person who holds  the wallet</p>
        /// </summary>
        [JsonProperty("WalletHolderName")]
        public string WalletHolderName{ get; set; }

        /// <summary>
        /// <p>The provider of the wallet, such as wechat, alipay, paypal</p>
        /// </summary>
        [JsonProperty("WalletProvider")]
        public string WalletProvider{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WalletType", this.WalletType);
            this.SetParamSimple(map, prefix + "WalletAddress", this.WalletAddress);
            this.SetParamSimple(map, prefix + "WalletHolderName", this.WalletHolderName);
            this.SetParamSimple(map, prefix + "WalletProvider", this.WalletProvider);
        }
    }
}

