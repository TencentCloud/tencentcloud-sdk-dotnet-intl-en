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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EditDetail : AbstractModel
    {
        
        /// <summary>
        /// Modified Field Name
        /// </summary>
        [JsonProperty("FieldName")]
        public string FieldName{ get; set; }

        /// <summary>
        /// Value of the field before modification, the original OCR result
        /// </summary>
        [JsonProperty("OriginalFieldValue")]
        public string OriginalFieldValue{ get; set; }

        /// <summary>
        /// Value of the field after modification,the user's manually entered result
        /// </summary>
        [JsonProperty("RevisedFieldValue")]
        public string RevisedFieldValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FieldName", this.FieldName);
            this.SetParamSimple(map, prefix + "OriginalFieldValue", this.OriginalFieldValue);
            this.SetParamSimple(map, prefix + "RevisedFieldValue", this.RevisedFieldValue);
        }
    }
}

