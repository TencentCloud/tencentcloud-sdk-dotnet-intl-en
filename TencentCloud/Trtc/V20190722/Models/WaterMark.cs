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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WaterMark : AbstractModel
    {
        
        /// <summary>
        /// The watermark type. 0 (default): image; 1: text (not supported yet).
        /// </summary>
        [JsonProperty("WaterMarkType")]
        public ulong? WaterMarkType{ get; set; }

        /// <summary>
        /// The information of watermark images. This parameter is required if the watermark type is image.
        /// </summary>
        [JsonProperty("WaterMarkImage")]
        public WaterMarkImage WaterMarkImage{ get; set; }

        /// <summary>
        /// The information of the text watermark. This parameter is required if `WaterMarkType` is `1`.
        /// </summary>
        [JsonProperty("WaterMarkChar")]
        public WaterMarkChar WaterMarkChar{ get; set; }

        /// <summary>
        /// The information of the timestamp watermark. This parameter is required if `WaterMarkType` is `2`.
        /// </summary>
        [JsonProperty("WaterMarkTimestamp")]
        public WaterMarkTimestamp WaterMarkTimestamp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WaterMarkType", this.WaterMarkType);
            this.SetParamObj(map, prefix + "WaterMarkImage.", this.WaterMarkImage);
            this.SetParamObj(map, prefix + "WaterMarkChar.", this.WaterMarkChar);
            this.SetParamObj(map, prefix + "WaterMarkTimestamp.", this.WaterMarkTimestamp);
        }
    }
}

