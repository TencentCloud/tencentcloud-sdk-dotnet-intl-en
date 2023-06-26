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

    public class RecognizeTableAccurateOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// The recognized text information. Please click the link on the left for details.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TableDetections")]
        public TableInfo[] TableDetections{ get; set; }

        /// <summary>
        /// Base64-encoded Excel data.
        /// </summary>
        [JsonProperty("Data")]
        public string Data{ get; set; }

        /// <summary>
        /// The total number of pages in the PDF file.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PdfPageSize")]
        public long? PdfPageSize{ get; set; }

        /// <summary>
        /// Image rotation angle in degrees. 0°: The horizontal direction of the text on the image; a negative value: rotate counterclockwise. Value range: -360° to 0°.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Angle")]
        public float? Angle{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "TableDetections.", this.TableDetections);
            this.SetParamSimple(map, prefix + "Data", this.Data);
            this.SetParamSimple(map, prefix + "PdfPageSize", this.PdfPageSize);
            this.SetParamSimple(map, prefix + "Angle", this.Angle);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

