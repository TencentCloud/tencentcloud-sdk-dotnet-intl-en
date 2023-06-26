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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SealOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// Seal content
        /// </summary>
        [JsonProperty("SealBody")]
        public string SealBody{ get; set; }

        /// <summary>
        /// Seal coordinates
        /// </summary>
        [JsonProperty("Location")]
        public Rect Location{ get; set; }

        /// <summary>
        /// Other text content
        /// </summary>
        [JsonProperty("OtherTexts")]
        public string[] OtherTexts{ get; set; }

        /// <summary>
        /// All seal information
        /// </summary>
        [JsonProperty("SealInfos")]
        public SealInfo[] SealInfos{ get; set; }

        /// <summary>
        /// Seal shape. Valid values:
        /// 0: Round
        /// 1: Oval
        /// 2: Rectangle
        /// 3: Diamond
        /// 4: Triangle
        /// </summary>
        [JsonProperty("SealShape")]
        public string SealShape{ get; set; }

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
            this.SetParamSimple(map, prefix + "SealBody", this.SealBody);
            this.SetParamObj(map, prefix + "Location.", this.Location);
            this.SetParamArraySimple(map, prefix + "OtherTexts.", this.OtherTexts);
            this.SetParamArrayObj(map, prefix + "SealInfos.", this.SealInfos);
            this.SetParamSimple(map, prefix + "SealShape", this.SealShape);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

