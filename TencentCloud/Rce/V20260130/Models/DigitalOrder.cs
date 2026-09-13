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

    public class DigitalOrder : AbstractModel
    {
        
        /// <summary>
        /// <p>The name of the asset</p>
        /// </summary>
        [JsonProperty("DigitalAsset")]
        public string DigitalAsset{ get; set; }

        /// <summary>
        /// <p>The type of the asset</p><p>Enumeration value:</p><ul><li>coin</li><li>commodity</li><li>crypto</li><li>fiat</li><li>token</li><li>stock</li><li>bond</li></ul>
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// <p>The type of trade being made</p><p>Enumeration value:</p><ul><li>limit: Limit order</li><li>market: Market order</li><li>stop_limit: Stop-limit order</li><li>stop_loss: Stop-loss order</li><li>take_profit: Take-profit order</li><li>take_profit_limit: Take-profit limit order</li></ul>
        /// </summary>
        [JsonProperty("OrderType")]
        public string OrderType{ get; set; }

        /// <summary>
        /// <p>The quantity of the digital asset</p>
        /// </summary>
        [JsonProperty("Volume")]
        public float? Volume{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DigitalAsset", this.DigitalAsset);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
        }
    }
}

