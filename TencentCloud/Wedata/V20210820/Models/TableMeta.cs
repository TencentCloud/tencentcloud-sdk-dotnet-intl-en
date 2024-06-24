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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TableMeta : AbstractModel
    {
        
        /// <summary>
        /// Global Unique ID of the Table
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TableId")]
        public string TableId{ get; set; }

        /// <summary>
        /// Table NameNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// Person in ChargeNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TableOwnerName")]
        public string TableOwnerName{ get; set; }

        /// <summary>
        /// Data Source Global Unique ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DatasourceId")]
        public long? DatasourceId{ get; set; }

        /// <summary>
        /// Cluster Name
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// Data Source Name
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DatasourceName")]
        public string DatasourceName{ get; set; }

        /// <summary>
        /// Database nameNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// Table Path
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TablePath")]
        public string TablePath{ get; set; }

        /// <summary>
        /// Chinese Table Name
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TableNameCn")]
        public string TableNameCn{ get; set; }

        /// <summary>
        /// Metadata Tenant ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("MetastoreId")]
        public long? MetastoreId{ get; set; }

        /// <summary>
        /// Technology Type, available values: HIVE,MYSQL,KAFKA, HBASE
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("MetastoreType")]
        public string MetastoreType{ get; set; }

        /// <summary>
        /// Table Description
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Column Separator
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ColumnSeparator")]
        public string ColumnSeparator{ get; set; }

        /// <summary>
        /// Storage Format
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("StorageFormat")]
        public string StorageFormat{ get; set; }

        /// <summary>
        /// Storage Volume, Byte Count
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("StorageSize")]
        public long? StorageSize{ get; set; }

        /// <summary>
        /// Table Types, such as hive MANAGED_TABLE;EXTERNAL_TABLE
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TableType")]
        public string TableType{ get; set; }

        /// <summary>
        /// Creation TimeNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Latest Data Modification Time
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// Latest DDL Modification Time
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DdlModifyTime")]
        public string DdlModifyTime{ get; set; }

        /// <summary>
        /// Last Access Time of Data
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("LastAccessTime")]
        public string LastAccessTime{ get; set; }

        /// <summary>
        /// Project Name in English
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// Data Directory ID (may be multiple)
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("BizCatalogIds")]
        public string[] BizCatalogIds{ get; set; }

        /// <summary>
        /// Data Directory (may be multiple)
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("BizCatalogNames")]
        public string[] BizCatalogNames{ get; set; }

        /// <summary>
        /// true for Favorited/false indicates not favorited
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("HasFavorite")]
        public bool? HasFavorite{ get; set; }

        /// <summary>
        /// LifecycleNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("LifeCycleTime")]
        public long? LifeCycleTime{ get; set; }

        /// <summary>
        /// Storage Volume, displayed in appropriate units
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("StorageSizeWithUnit")]
        public string StorageSizeWithUnit{ get; set; }

        /// <summary>
        /// Instance ID of the Data Source Engine: e.g., EMR Cluster Instance ID/Data Source Instance ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Data Source Technology Type: HIVE/MYSQL/HBASE/KAFKA etc.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TechnologyType")]
        public string TechnologyType{ get; set; }

        /// <summary>
        /// Table English Name
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TableNameEn")]
        public string TableNameEn{ get; set; }

        /// <summary>
        /// Project IDNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Number of partitions in Kafka Topic
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Partitions")]
        public string Partitions{ get; set; }

        /// <summary>
        /// Number of replicas in Kafka Topic
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ReplicationFactor")]
        public string ReplicationFactor{ get; set; }

        /// <summary>
        /// Project English and Chinese Name
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ProjectDisplayName")]
        public string ProjectDisplayName{ get; set; }

        /// <summary>
        /// Last Modified Time of Data
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DataModifyTime")]
        public string DataModifyTime{ get; set; }

        /// <summary>
        /// Cluster ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Current user has Administrator Privileges
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("HasAdminAuthority")]
        public bool? HasAdminAuthority{ get; set; }

        /// <summary>
        /// Data Source Display Name
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DatasourceDisplayName")]
        public string DatasourceDisplayName{ get; set; }

        /// <summary>
        /// Database ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DatabaseId")]
        public string DatabaseId{ get; set; }

        /// <summary>
        /// Total favorites on the table under the tenant
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("FavoriteCount")]
        public long? FavoriteCount{ get; set; }

        /// <summary>
        /// Total likes on the table under the tenant
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("LikeCount")]
        public long? LikeCount{ get; set; }

        /// <summary>
        /// true for liked/false for not liked status
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("HasLike")]
        public bool? HasLike{ get; set; }

        /// <summary>
        /// Asset score of the table
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TablePropertyScore")]
        public TablePropertyScore TablePropertyScore{ get; set; }

        /// <summary>
        /// Heat value of the table
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TableHeat")]
        public TableHeat TableHeat{ get; set; }

        /// <summary>
        /// Data source ownerProjectId
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("OwnerProjectId")]
        public string OwnerProjectId{ get; set; }

        /// <summary>
        /// Table Owner ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TableOwnerId")]
        public string TableOwnerId{ get; set; }

        /// <summary>
        /// System Source -CLUSTER, DB - Self Definition Source
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DataSourceCategory")]
        public string DataSourceCategory{ get; set; }

        /// <summary>
        /// Table Field Information
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Columns")]
        public SearchColumnDocVO[] Columns{ get; set; }

        /// <summary>
        /// Table Collection Type
        /// TABLE, VIEW, MANAGED_TABLE (Hive managed table), EXTERNAL_TABLE (Hive external table), VIRTUAL_VIEW (virtual view), MATERIALIZED_VIEW (materialized view), LATERAL_VIEW, INDEX_TABLE (index table), END_SELECT (query structure), INSTANCE (intermediate temporary table type (data lineage)), CDW (CDW table type)
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("MetaCrawlType")]
        public string MetaCrawlType{ get; set; }

        /// <summary>
        /// Is View
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("IsView")]
        public bool? IsView{ get; set; }

        /// <summary>
        /// Storage locationNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// Determine if it is a partitioned table 1 Yes 0 No
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("IsPartitionTable")]
        public long? IsPartitionTable{ get; set; }

        /// <summary>
        /// Partition Field Key
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("PartitionColumns")]
        public string[] PartitionColumns{ get; set; }

        /// <summary>
        /// Lifecycle - Partition Retention Days [Valid when Partition Retention Policy is applied]
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("PartitionExpireDays")]
        public long? PartitionExpireDays{ get; set; }

        /// <summary>
        /// Table Ancillary Information
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TableProperties")]
        public TableMetaProperty[] TableProperties{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableId", this.TableId);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "TableOwnerName", this.TableOwnerName);
            this.SetParamSimple(map, prefix + "DatasourceId", this.DatasourceId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "DatasourceName", this.DatasourceName);
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "TablePath", this.TablePath);
            this.SetParamSimple(map, prefix + "TableNameCn", this.TableNameCn);
            this.SetParamSimple(map, prefix + "MetastoreId", this.MetastoreId);
            this.SetParamSimple(map, prefix + "MetastoreType", this.MetastoreType);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ColumnSeparator", this.ColumnSeparator);
            this.SetParamSimple(map, prefix + "StorageFormat", this.StorageFormat);
            this.SetParamSimple(map, prefix + "StorageSize", this.StorageSize);
            this.SetParamSimple(map, prefix + "TableType", this.TableType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "DdlModifyTime", this.DdlModifyTime);
            this.SetParamSimple(map, prefix + "LastAccessTime", this.LastAccessTime);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamArraySimple(map, prefix + "BizCatalogIds.", this.BizCatalogIds);
            this.SetParamArraySimple(map, prefix + "BizCatalogNames.", this.BizCatalogNames);
            this.SetParamSimple(map, prefix + "HasFavorite", this.HasFavorite);
            this.SetParamSimple(map, prefix + "LifeCycleTime", this.LifeCycleTime);
            this.SetParamSimple(map, prefix + "StorageSizeWithUnit", this.StorageSizeWithUnit);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "TechnologyType", this.TechnologyType);
            this.SetParamSimple(map, prefix + "TableNameEn", this.TableNameEn);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Partitions", this.Partitions);
            this.SetParamSimple(map, prefix + "ReplicationFactor", this.ReplicationFactor);
            this.SetParamSimple(map, prefix + "ProjectDisplayName", this.ProjectDisplayName);
            this.SetParamSimple(map, prefix + "DataModifyTime", this.DataModifyTime);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "HasAdminAuthority", this.HasAdminAuthority);
            this.SetParamSimple(map, prefix + "DatasourceDisplayName", this.DatasourceDisplayName);
            this.SetParamSimple(map, prefix + "DatabaseId", this.DatabaseId);
            this.SetParamSimple(map, prefix + "FavoriteCount", this.FavoriteCount);
            this.SetParamSimple(map, prefix + "LikeCount", this.LikeCount);
            this.SetParamSimple(map, prefix + "HasLike", this.HasLike);
            this.SetParamObj(map, prefix + "TablePropertyScore.", this.TablePropertyScore);
            this.SetParamObj(map, prefix + "TableHeat.", this.TableHeat);
            this.SetParamSimple(map, prefix + "OwnerProjectId", this.OwnerProjectId);
            this.SetParamSimple(map, prefix + "TableOwnerId", this.TableOwnerId);
            this.SetParamSimple(map, prefix + "DataSourceCategory", this.DataSourceCategory);
            this.SetParamArrayObj(map, prefix + "Columns.", this.Columns);
            this.SetParamSimple(map, prefix + "MetaCrawlType", this.MetaCrawlType);
            this.SetParamSimple(map, prefix + "IsView", this.IsView);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "IsPartitionTable", this.IsPartitionTable);
            this.SetParamArraySimple(map, prefix + "PartitionColumns.", this.PartitionColumns);
            this.SetParamSimple(map, prefix + "PartitionExpireDays", this.PartitionExpireDays);
            this.SetParamArrayObj(map, prefix + "TableProperties.", this.TableProperties);
        }
    }
}

