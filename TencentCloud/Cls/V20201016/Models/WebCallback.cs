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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WebCallback : AbstractModel
    {
        
        /// <summary>
        /// Callback address
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// Callback type. Valid values:
        /// <br><li> WeCom
        /// <br><li> Http
        /// </summary>
        [JsonProperty("CallbackType")]
        public string CallbackType{ get; set; }

        /// <summary>
        /// Callback method. Valid values:
        /// <br><li> POST
        /// <br><li> PUT
        /// Default value: `POST`. This parameter is required if `CallbackType` is `Http`.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// Request header
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Headers")]
        public string[] Headers{ get; set; }

        /// <summary>
        /// Request content, which is required when `CallbackType` is `Http`.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Body")]
        public string Body{ get; set; }

        /// <summary>
        /// Number
        /// </summary>
        [JsonProperty("Index")]
        public long? Index{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "CallbackType", this.CallbackType);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamArraySimple(map, prefix + "Headers.", this.Headers);
            this.SetParamSimple(map, prefix + "Body", this.Body);
            this.SetParamSimple(map, prefix + "Index", this.Index);
        }
    }
}

