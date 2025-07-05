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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DdlOption : AbstractModel
    {
        
        /// <summary>
        /// DDL type, such as database, table, view, and index.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DdlObject")]
        public string DdlObject{ get; set; }

        /// <summary>
        /// DDL value. Valid values: [Create,Drop,Alter] for database <br>[Create,Drop,Alter,Truncate,Rename] for table <br/>[Create,Drop] for view <br/>[Create,Drop] for index
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DdlValue")]
        public string[] DdlValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DdlObject", this.DdlObject);
            this.SetParamArraySimple(map, prefix + "DdlValue.", this.DdlValue);
        }
    }
}

