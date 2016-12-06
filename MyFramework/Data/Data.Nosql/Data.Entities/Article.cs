using Nest;
namespace ES.Data.Entities
{
  [ElasticsearchType(Name = "Article", IdProperty = "Id")]
  public class Article
  {
     
	    /// <summary>
        /// id值
        /// </summary>
		[Number(Name="id")]
		public int  Id { set; get; }


		
	    /// <summary>
        /// 名称
        /// </summary>
		[String(Name="name")]
		public string  Name { set; get; }


		
  }
}
 