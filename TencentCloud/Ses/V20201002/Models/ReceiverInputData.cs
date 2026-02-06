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

namespace TencentCloud.Ses.V20201002.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReceiverInputData : AbstractModel
    {
        
        /// <summary>
        /// Recipient email.
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// For variable parameters in template, please use json.dump to format the json object into string type. the object is a set of Key-value pairs. each Key represents a variable in template. variable usage in template is represented by {{Key}}. the appropriate value will be replaced with {{value}} when sent.
        /// Note: the parameter value cannot be data of complex type such as html. the entire JSON structure of TemplateData has a length limit of 800 bytes.
        /// </summary>
        [JsonProperty("TemplateData")]
        public string TemplateData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "TemplateData", this.TemplateData);
        }
    }
}

