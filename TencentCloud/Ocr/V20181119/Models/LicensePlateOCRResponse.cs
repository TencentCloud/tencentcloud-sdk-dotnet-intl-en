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

    public class LicensePlateOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// The recognized license plate number.
        /// </summary>
        [JsonProperty("Number")]
        public string Number{ get; set; }

        /// <summary>
        /// The confidence score (0–100).
        /// </summary>
        [JsonProperty("Confidence")]
        public long? Confidence{ get; set; }

        /// <summary>
        /// The bounding box coordinates of the text line in the original image.
        /// </summary>
        [JsonProperty("Rect")]
        public Rect Rect{ get; set; }

        /// <summary>
        /// The recognized license plate color, which currently includes "white", "black", "blue", "green", "yellow", "yellow-green", and "temporary plate".
        /// </summary>
        [JsonProperty("Color")]
        public string Color{ get; set; }

        /// <summary>
        /// The vehicle license plate information.
        /// </summary>
        [JsonProperty("LicensePlateInfos")]
        public LicensePlateInfo[] LicensePlateInfos{ get; set; }

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
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamObj(map, prefix + "Rect.", this.Rect);
            this.SetParamSimple(map, prefix + "Color", this.Color);
            this.SetParamArrayObj(map, prefix + "LicensePlateInfos.", this.LicensePlateInfos);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

