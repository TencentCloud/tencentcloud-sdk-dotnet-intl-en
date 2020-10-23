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

namespace TencentCloud.Dts.V20180330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConsistencyParams : AbstractModel
    {
        
        /// <summary>
        /// Data content check parameter, which refers to the proportion of the rows selected for data comparison in all the rows of the table. Value: an integer between 1 and 100.
        /// </summary>
        [JsonProperty("SelectRowsPerTable")]
        public long? SelectRowsPerTable{ get; set; }

        /// <summary>
        /// Data content check parameter, which refers to the proportion of the tables selected for data detection in all the tables. Value: an integer between 1 and 100.
        /// </summary>
        [JsonProperty("TablesSelectAll")]
        public long? TablesSelectAll{ get; set; }

        /// <summary>
        /// Data quantity check parameter, which checks whether the numbers of rows are identical. It refers to the proportion of the tables selected for quantity check in all the tables. Value: an integer between 1 and 100.
        /// </summary>
        [JsonProperty("TablesSelectCount")]
        public long? TablesSelectCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SelectRowsPerTable", this.SelectRowsPerTable);
            this.SetParamSimple(map, prefix + "TablesSelectAll", this.TablesSelectAll);
            this.SetParamSimple(map, prefix + "TablesSelectCount", this.TablesSelectCount);
        }
    }
}

