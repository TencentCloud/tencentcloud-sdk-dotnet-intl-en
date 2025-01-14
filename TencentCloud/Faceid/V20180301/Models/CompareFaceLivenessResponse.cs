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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CompareFaceLivenessResponse : AbstractModel
    {
        
        /// <summary>
        /// Business Error Codes.
        /// -When the return value is "Success", it indicates that liveness detection and face comparison passed. Determined to be the same person.
        /// -When the return value is "FailedOperation.CompareLowSimilarity", it indicates that liveness detection passed, but face comparison similarity is below 70. Determined not to be the same person.
        /// -For other error cases, please refer to [Liveness Face Comparison (API only) Error Codes](https://www.tencentcloud.com/zh/document/product/1061/55390?lang=zh&pg=#97df7537-87fe-4266-87e9-02c816d41ee2)
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// The service result description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// This value indicates the similarity of face comparison. Value range: 0.00-100.00.
        /// - The false acceptance rate for a threshold of 70 is 0.1%, and for a threshold of 80, it is 0.01%.
        /// - This value is valid when the Result parameter is "Success" or "FailedOperation.CompareLowSimilarity".
        /// </summary>
        [JsonProperty("Sim")]
        public float? Sim{ get; set; }

        /// <summary>
        /// The best screenshot photo from the video after verification, encoded in BASE64, in jpg format.
        /// The optimal screenshot of the video after verification is the value encoded by BASE64, jpg format. 
        /// Note: This field may return "null", indicating that no valid value can be obtained. 
        /// Example values: "/9j/4AAQSk... (total length:142036)s97n//2Q=="
        /// </summary>
        [JsonProperty("BestFrameBase64")]
        public string BestFrameBase64{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Sim", this.Sim);
            this.SetParamSimple(map, prefix + "BestFrameBase64", this.BestFrameBase64);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

