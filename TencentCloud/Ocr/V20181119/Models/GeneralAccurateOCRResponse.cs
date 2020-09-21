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

    public class GeneralAccurateOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// Information on recognized text, including the text line content, confidence, text line coordinates, and text line coordinates after rotation correction. For more information, please click the link on the left.
        /// </summary>
        [JsonProperty("TextDetections")]
        public TextDetection[] TextDetections{ get; set; }

        /// <summary>
        /// Image rotation angle in degrees. 0° indicates horizontal text, a positive value indicates clockwise rotation, and a negative value indicates anticlockwise rotation.
        /// </summary>
        [JsonProperty("Angel")]
        public float? Angel{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "TextDetections.", this.TextDetections);
            this.SetParamSimple(map, prefix + "Angel", this.Angel);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

