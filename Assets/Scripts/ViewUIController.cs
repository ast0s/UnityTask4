using TMPro;
using UnityEngine;

public class ViewUIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _title;
    [SerializeField] private TextMeshProUGUI _developer;
    [SerializeField] private TextMeshProUGUI _additionalInfo;

    [SerializeField] private TextMeshProUGUI _shortRating;
    [SerializeField] private TextMeshProUGUI _shortReviews;

    [SerializeField] private TextMeshProUGUI _downloadSize;

    [SerializeField] private TextMeshProUGUI _pg;

    [SerializeField] private TextMeshProUGUI _timesDownloaded;

    [SerializeField] private TextMeshProUGUI _aboutApp;

    [SerializeField] private TextMeshProUGUI _overallRating;
    [SerializeField] private TextMeshProUGUI _overallTimesRated;
    [SerializeField] private GameObject _overallStars;
    [SerializeField] private GameObject _overallProgressbars;


    [SerializeField] private TextMeshProUGUI _commentatorOneNickname;
    [SerializeField] private TextMeshProUGUI _commentOneDate;
    [SerializeField] private TextMeshProUGUI _commentOneText;
    [SerializeField] private GameObject _commentOneStars;

    [SerializeField] private TextMeshProUGUI _commentatorTwoNickname;
    [SerializeField] private TextMeshProUGUI _commentTwoDate;
    [SerializeField] private TextMeshProUGUI _commentTwoText;
    [SerializeField] private GameObject _commentTwoStars;

    private void Awake()
    {
        _title.text = "Title name";
        _developer.text = "Developer name";
        _additionalInfo.text = "additional information";

        _shortRating.text = "_,_";
        _shortReviews.text = "___k reviews";

        _downloadSize.text = "___MB";
        _pg.text = "+_";

        _timesDownloaded.text = "___kk+";

        _aboutApp.text = "___________________";
        
        _overallRating.text = "_,_";
        _overallTimesRated.text = "___ ___ ___";

        _commentatorOneNickname.text = "Ast0s";
        _commentOneDate.text = "30.03.2023";
        _commentOneText.text = "My review is very important blah blah blah";

        _commentatorOneNickname.text = "Ast0s";
        _commentOneDate.text = "31.03.2023";
        _commentOneText.text = "My review is very important blah blah blah (2)";
    }
}
