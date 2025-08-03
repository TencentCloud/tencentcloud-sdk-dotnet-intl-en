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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ErrorInfo : AbstractModel
    {
        
        /// <summary>
        /// Error description field.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ErrorTip")]
        public string ErrorTip{ get; set; }

        /// <summary>
        /// Original exception message.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ErrorMessage")]
        public string ErrorMessage{ get; set; }

        /// <summary>
        /// Error level field.
        /// ERROR
        /// WARN
        /// INFO
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ErrorLevel")]
        public string ErrorLevel{ get; set; }

        /// <summary>
        /// Documentation link.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DocLink")]
        public string DocLink{ get; set; }

        /// <summary>
        /// Quick start guide.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FAQ")]
        public string FAQ{ get; set; }

        /// <summary>
        /// Reserved field 1.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ReservedField")]
        public string ReservedField{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ErrorTip", this.ErrorTip);
            this.SetParamSimple(map, prefix + "ErrorMessage", this.ErrorMessage);
            this.SetParamSimple(map, prefix + "ErrorLevel", this.ErrorLevel);
            this.SetParamSimple(map, prefix + "DocLink", this.DocLink);
            this.SetParamSimple(map, prefix + "FAQ", this.FAQ);
            this.SetParamSimple(map, prefix + "ReservedField", this.ReservedField);
        }
    }
}

