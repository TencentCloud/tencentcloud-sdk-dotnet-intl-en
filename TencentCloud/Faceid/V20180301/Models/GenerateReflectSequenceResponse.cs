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

    public class GenerateReflectSequenceResponse : AbstractModel
    {
        
        /// <summary>
        /// The resource URL of the light sequence, which needs to be downloaded and passed through to the SDK to start the identity verification process.
        /// </summary>
        [JsonProperty("ReflectSequenceUrl")]
        public string ReflectSequenceUrl{ get; set; }

        /// <summary>
        /// The MD5 hash value of the light sequence, which is used to check whether the light sequence is altered.
        /// </summary>
        [JsonProperty("ReflectSequenceMd5")]
        public string ReflectSequenceMd5{ get; set; }

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
            this.SetParamSimple(map, prefix + "ReflectSequenceUrl", this.ReflectSequenceUrl);
            this.SetParamSimple(map, prefix + "ReflectSequenceMd5", this.ReflectSequenceMd5);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

