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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class McuWaterMarkParams : AbstractModel
    {
        
        /// <summary>
        /// The watermark type. Valid values: `0` (default): Image; `1`: Text.
        /// </summary>
        [JsonProperty("WaterMarkType")]
        public ulong? WaterMarkType{ get; set; }

        /// <summary>
        /// The watermark image information. This parameter is required if `WaterMarkType` is 0.
        /// </summary>
        [JsonProperty("WaterMarkImage")]
        public McuWaterMarkImage WaterMarkImage{ get; set; }

        /// <summary>
        /// The text watermark configuration. This parameter is required if `WaterMarkType` is `1`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WaterMarkText")]
        public McuWaterMarkText WaterMarkText{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WaterMarkType", this.WaterMarkType);
            this.SetParamObj(map, prefix + "WaterMarkImage.", this.WaterMarkImage);
            this.SetParamObj(map, prefix + "WaterMarkText.", this.WaterMarkText);
        }
    }
}

