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

namespace TencentCloud.Captcha.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCaptchaResultResponse : AbstractModel
    {
        
        /// <summary>
        ///  
        ///  
        ///  
        ///  
        ///  
        ///  
        ///  
        ///  
        ///  
        ///  
        ///  
        ///  
        ///  
        ///  
        ///  
        ///   
        ///   
        ///  
        ///  
        ///  
        ///  
        ///  
        ///   
        ///  
        /// </summary>
        [JsonProperty("CaptchaCode")]
        public long? CaptchaCode{ get; set; }

        /// <summary>
        /// Status description and verification error message
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("CaptchaMsg")]
        public string CaptchaMsg{ get; set; }

        /// <summary>
        /// This parameter returns the result of imperceptible verification. This parameter is not available for Tencent Cloud International yet.
        /// `0`: The request is trusted.
        /// `100`: The request is malicious.
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("EvilLevel")]
        public long? EvilLevel{ get; set; }

        /// <summary>
        /// The timestamp when the frontend obtains the CAPTCHA.
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("GetCaptchaTime")]
        public long? GetCaptchaTime{ get; set; }

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
            this.SetParamSimple(map, prefix + "CaptchaCode", this.CaptchaCode);
            this.SetParamSimple(map, prefix + "CaptchaMsg", this.CaptchaMsg);
            this.SetParamSimple(map, prefix + "EvilLevel", this.EvilLevel);
            this.SetParamSimple(map, prefix + "GetCaptchaTime", this.GetCaptchaTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

